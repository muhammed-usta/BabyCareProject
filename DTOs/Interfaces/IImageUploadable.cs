namespace BabyCareProject.DTOs.Interfaces
{
    public interface IImageUploadable
    {
        IFormFile ImageFile { get; set; }
        string ImageUrl { get; set; }
    }
}
