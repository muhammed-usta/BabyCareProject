using BabyCareProject.DTOs.ServiceDtos;

namespace BabyCareProject.Services.ServiceServices
{
    public interface IServiceService
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        Task<UpdateServiceDto> GetServiceByIdAsync(string id);
        Task CreateServiceAsync(CreateServiceDto createServiceDto);
        Task UpdateServiceAsync(UpdateServiceDto updateServiceDto);
        Task DeleteServiceByIdAsync(string id);
    }
}
