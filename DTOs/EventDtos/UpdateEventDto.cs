using BabyCareProject.DTOs.Interfaces;

namespace BabyCareProject.DTOs.EventDtos
{
    public class UpdateEventDto : IImageUploadable
    {
        public string EventId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Location { get; set; }
        public string ImageUrl { get; set; }

        public IFormFile ImageFile { get; set; }
    }
}
