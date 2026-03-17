using BabyCareProject.DTOs.Interfaces;

namespace BabyCareProject.Services.ImageServices
{
    public class ImageUploadHelper
    {
        private readonly IImageService _imageService;

        public ImageUploadHelper(IImageService imageService)
        {
            _imageService = imageService;
        }

        public async Task<(bool isSuccess, string errorMessage)> TryUploadIfExistsAsync(object model)
        {
            if (model is IImageUploadable uploadable && uploadable.ImageFile != null)
            {
                try
                {
                    uploadable.ImageUrl = await _imageService.SaveImageAsync(uploadable.ImageFile);
                    return (true, string.Empty);
                }
                catch (Exception ex)
                {
                    return (false, "Image upload error: " + ex.Message);
                }
            }

            return (true, string.Empty); 
        }
    }
}
