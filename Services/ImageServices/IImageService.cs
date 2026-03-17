namespace BabyCareProject.Services.ImageServices
{
    
        public interface IImageService
        {
            /// <summary>
            /// 
            /// </summary>
            /// <param name="file"></param>
            /// <returns> Returns a string value for the model's ImageUrl Property </returns>
            Task<string> SaveImageAsync(IFormFile file);
        }
    
}
