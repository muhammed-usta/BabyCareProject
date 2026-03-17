using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DataAccess.Settings;
using BabyCareProject.DTOs.BannerDtos;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

namespace BabyCareProject.Services.BannerServices
{
    public class BannerService : IBannerService
    {
        private readonly IMongoCollection<Banner> _bannerCollection;
        private readonly IMapper _mapper;

        public BannerService(IDatabaseSettings databaseSettings, IMapper mapper)
        {
            _mapper = mapper;
            var client=new MongoClient(databaseSettings.ConnectionString);
            var database=client.GetDatabase(databaseSettings.DatabaseName);
            _bannerCollection=database.GetCollection<Banner>(databaseSettings.BannerCollectionName);
        }
        public async Task CreateBannerAsync(CreateBannerDto createBannerDto)
        {
            var banner= _mapper.Map<Banner>(createBannerDto);
            await _bannerCollection.InsertOneAsync(banner);
        }

        public async Task DeleteBannerAsync(string id)
        {
            await _bannerCollection.DeleteOneAsync(x=>x.BannerId==id); 
        }

        public async Task<List<ResultBannerDto>> GetAllBannerAsync()
        {
            var values= await _bannerCollection.AsQueryable().ToListAsync();
            return _mapper.Map<List<ResultBannerDto>>(values);
        }

        public async Task<UpdateBannerDto> GetBannerByIdAsync(string id)
        {
            var banner= await _bannerCollection.Find(x=>x.BannerId==id).FirstOrDefaultAsync();
            return _mapper.Map<UpdateBannerDto>(banner);
        }

        public async Task UpdateBannerAsync(UpdateBannerDto updateBannerDto)
        {
            var banner= _mapper.Map<Banner>(updateBannerDto);
            await _bannerCollection.FindOneAndReplaceAsync(x=>x.BannerId==banner.BannerId,banner);
        }
    }
}
