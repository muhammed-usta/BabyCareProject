using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.DTOs.ServiceDtos;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.ServiceServices
{
    public class ServiceService : IServiceService
    {
        private readonly IMongoCollection<Service> _serviceCollection;
        private readonly IMapper _mapper;

        public ServiceService(IDatabaseSettings databaseSettings, IMapper mapper)
        {
            _mapper = mapper;
            var client = new MongoClient(databaseSettings.ConnectionString);
            var database = client.GetDatabase(databaseSettings.DatabaseName);
            _serviceCollection = database.GetCollection<Service>(databaseSettings.ServiceCollectionName);
        }

        public async Task CreateServiceAsync(CreateServiceDto createServiceDto)
        {
            var service = _mapper.Map<Service>(createServiceDto);
            await _serviceCollection.InsertOneAsync(service);
        }

        public async Task DeleteServiceByIdAsync(string id)
        {
            await _serviceCollection.DeleteOneAsync(x => x.ServiceId == id);
        }

        public async Task<List<ResultServiceDto>> GetAllServiceAsync()
        {
            var values = await _serviceCollection.AsQueryable().ToListAsync();
            return _mapper.Map<List<ResultServiceDto>>(values);
        }

        public async Task<UpdateServiceDto> GetServiceByIdAsync(string id)
        {
            var service = await _serviceCollection.Find(x => x.ServiceId == id).FirstOrDefaultAsync();
            return _mapper.Map<UpdateServiceDto>(service);
        }

        public async Task UpdateServiceAsync(UpdateServiceDto updateServiceDto)
        {
            var service = _mapper.Map<Service>(updateServiceDto);
            await _serviceCollection.FindOneAndReplaceAsync(x => x.ServiceId == service.ServiceId, service);
        }
    }
}
