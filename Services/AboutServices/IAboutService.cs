using BabyCareProject.DTOs.AboutDtos;

namespace BabyCareProject.Services.AboutServices
{
    public interface IAboutService
    {
        Task<List<ResultAboutDto>> GetAllAboutAsync();
        Task<UpdateAboutDto> GetAboutByIdAsync(string id);
        Task CreateAboutAsync(CreateAboutDto createAboutDto);
        Task UpateAboutAsync(UpdateAboutDto updateAboutDto);
        Task DeleteAboutAsync(string id);


    }
}
