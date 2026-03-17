using AutoMapper;
using BabyCareProject.DataAccess.Entities;
using BabyCareProject.DTOs.EventDtos;

namespace BabyCareProject.Mappings
{
    public class EventMapping:Profile
    {
        public EventMapping()
        {
                CreateMap<ResultEventDto, Event>().ReverseMap();
                CreateMap<CreateEventDto, Event>().ReverseMap();
                CreateMap<UpdateEventDto, Event>().ReverseMap();
        }
    }
}
