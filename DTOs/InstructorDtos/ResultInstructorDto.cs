namespace BabyCareProject.DTOs.InstructorDtos
{
    public class ResultInstructorDto
    {
        public string InstructorId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => string.Join(" ", FirstName, LastName);
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Social1 { get; set; }
        public string Social2 { get; set; }
        public string Social3 { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
