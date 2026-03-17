using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.DTOs.ContactDtos;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.ContactServices
{
    public class ContactService : IContactService
    {
        private readonly IMongoCollection<Contact> _contactCollection;
        private readonly IMapper _mapper;

        public ContactService(IDatabaseSettings databaseSettings, IMapper mapper)
        {
            _mapper = mapper;
            var client= new MongoClient(databaseSettings.ConnectionString);
            var database=client.GetDatabase(databaseSettings.DatabaseName);
            _contactCollection=database.GetCollection<Contact>(databaseSettings.ContactCollectionName);
        }
        public async Task CreateContactAsync(CreateContactDto createContactDto)
        {
            var contact= _mapper.Map<Contact>(createContactDto);
            await _contactCollection.InsertOneAsync(contact);
        }

        public async Task DeleteContactAsync(string id)
        {
            await _contactCollection.DeleteOneAsync(x=>x.ContactId==id);
        }

        public async Task<List<ResultContactDto>> GetAllContactAsync()
        {
           var values= await _contactCollection.AsQueryable().ToListAsync();
            return _mapper.Map<List<ResultContactDto>>(values);
        }

        public async Task<UpdateContactDto> GetContactByIdAsync(string id)
        {
            var contact= await _contactCollection.Find(x=>x.ContactId==id).FirstOrDefaultAsync();
            return _mapper.Map<UpdateContactDto>(contact);
        }

        public async Task UpdateContactAsync(UpdateContactDto updateContactDto)
        {
           var contact= _mapper.Map<Contact>(updateContactDto);
            await _contactCollection.FindOneAndReplaceAsync(x => x.ContactId == contact.ContactId, contact);
        }
    }
}
