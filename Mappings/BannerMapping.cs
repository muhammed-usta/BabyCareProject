using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DTOs.BannerDtos;

namespace BabyCareProject.Mappings
{
    public class BannerMapping:Profile  
    {
        public BannerMapping()
        {
            CreateMap<ResultBannerDto,Banner>().ReverseMap();
            CreateMap<CreateBannerDto,Banner>().ReverseMap();
            CreateMap<UpdateBannerDto,Banner>().ReverseMap();
        }
    }
}
