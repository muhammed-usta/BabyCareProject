using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DTOs.AboutDtos;

namespace BabyCareProject.Mappings
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
                CreateMap<ResultAboutDto, About>().ReverseMap();
                CreateMap<CreateAboutDto, About>().ReverseMap();
                CreateMap<UpdateAboutDto, About>().ReverseMap();
        }
    }
}
