using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DTOs.ServiceDtos;

namespace BabyCareProject.Mappings
{
    public class ServiceMapping:Profile
    {
        public ServiceMapping()
        {
                CreateMap<ResultServiceDto ,Service>().ReverseMap();
                CreateMap<CreateServiceDto ,Service>().ReverseMap();
                CreateMap<UpdateServiceDto ,Service>().ReverseMap();
        }
    }
}
