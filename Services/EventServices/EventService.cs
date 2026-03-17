using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.DTOs.EventDtos;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.EventServices
{
    public class EventService : IEventService
    {
        private readonly IMongoCollection<Event> _eventCollection;
        private readonly IMapper _mapper;

        public EventService(IDatabaseSettings databaseSettings, IMapper mapper)
        {
            _mapper = mapper;
            var client= new MongoClient(databaseSettings.ConnectionString); 
            var database= client.GetDatabase(databaseSettings.DatabaseName);
            _eventCollection=database.GetCollection<Event>(databaseSettings.EventCollectionName);
        }
        public async Task CreateEventAsync(CreateEventDto createEventDto)
        {
            var eventvalue= _mapper.Map<Event>(createEventDto);
            await _eventCollection.InsertOneAsync(eventvalue);
        }

        public async Task DeleteEventAsync(string id)
        {
           await _eventCollection.DeleteOneAsync(x=>x.EventId==id);
        }

        public async Task<List<ResultEventDto>> GetAllEventAsync()
        {
            var value= await _eventCollection.AsQueryable().ToListAsync();
            return _mapper.Map<List<ResultEventDto>>(value);
        }

        public async Task<UpdateEventDto> GetEventByIdAsync(string id)
        {
           var eventvalue= await _eventCollection.Find(x=>x.EventId==id).FirstOrDefaultAsync();
            return _mapper.Map<UpdateEventDto>(eventvalue);
        }

        public async Task UpdateEventAsync(UpdateEventDto updateEventDto)
        {
            var eventvalue= _mapper.Map<Event>(updateEventDto);
            await _eventCollection.FindOneAndReplaceAsync(x => x.EventId == eventvalue.EventId, eventvalue);
        }
    }
}
