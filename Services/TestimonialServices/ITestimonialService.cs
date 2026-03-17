using BabyCareProject.DTOs.TestimonialDtos;

namespace BabyCareProject.Services.TestimonialServices
{
    public interface ITestimonialService
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialAsync();
        Task<UpdateTestimonialDto> GetTestimonialByIdAsync(string id);
        Task CreateTestimonialAsync(CreateTestimonialDto createTestimonialDto);
        Task UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialDto);
        Task DeleteTestimonialAsync(string id); 
    }
}
