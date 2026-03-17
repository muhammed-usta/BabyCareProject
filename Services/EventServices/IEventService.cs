using BabyCareProject.DTOs.EventDtos;

namespace BabyCareProject.Services.EventServices
{
    public interface IEventService
    {
        Task<List<ResultEventDto>> GetAllEventAsync();
        Task<UpdateEventDto> GetEventByIdAsync(string id);
        Task CreateEventAsync(CreateEventDto createEventDto);
        Task UpdateEventAsync(UpdateEventDto updateEventDto);
        Task DeleteEventAsync(string id);

    }
}
