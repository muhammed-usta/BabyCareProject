using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DTOs.InstructorDtos;

namespace BabyCareProject.Mappings
{
    public class InstructorMapping:Profile
    {
        public InstructorMapping()
        {
            CreateMap<ResultInstructorDto, Instructor>().ReverseMap();
            CreateMap<CreateInstructorDto, Instructor>().ReverseMap();
            CreateMap<UpdateInstructorDto, Instructor>().ReverseMap();
        }
    }
}
