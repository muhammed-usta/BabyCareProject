using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DTOs.ContactDtos;

namespace BabyCareProject.Mappings
{
    public class ContactMapping:Profile
    {
        public ContactMapping()
        {
                CreateMap<ResultContactDto, Contact>().ReverseMap();
                CreateMap<CreateContactDto, Contact>().ReverseMap();
                CreateMap<UpdateContactDto, Contact>().ReverseMap();
        }
    }
}
