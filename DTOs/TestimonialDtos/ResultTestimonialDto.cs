namespace BabyCareProject.DTOs.TestimonialDtos
{
    public class ResultTestimonialDto
    {
        public string TestimonialId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Title { get; set; }
        public int Reviews { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }

        public IFormFile ImageFile { get; set; }
    }
}
