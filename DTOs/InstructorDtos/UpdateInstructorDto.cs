using BabyCareProject.DTOs.Interfaces;

namespace BabyCareProject.DTOs.InstructorDtos
{
    public class UpdateInstructorDto : IImageUploadable
    {
        public string InstructorId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Social1 { get; set; }
        public string Social2 { get; set; }
        public string Social3 { get; set; }
        public IFormFile ImageFile { get; set; }

    }
}
