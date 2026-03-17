using BabyCareProject.DTOs.Interfaces;

namespace BabyCareProject.DTOs.AboutDtos
{
    public class UpdateAboutDto
    {
        public string AboutId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string[] Items { get; set; }
     
        public string VideoUrl { get; set; }
    

    }
}
