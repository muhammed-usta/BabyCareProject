using BabyCareProject.DTOs.Interfaces;
using BabyCareProject.Services.ImageServices;

namespace BabyCareProject.DTOs.AboutDtos
{
    public class CreateAboutDto
    {
    
        public string Title { get; set; }
        public string Description { get; set; }
        public string[] Items { get; set; }
   
        public string VideoUrl { get; set; }
    
    }
}
