using BabyCareProject.Services.AboutServices;
using BabyCareProject.Services.BannerServices;
using BabyCareProject.Services.ContactServices;
using BabyCareProject.Services.EventServices;
using BabyCareProject.Services.ImageServices;
using BabyCareProject.Services.InstructorServices;
using BabyCareProject.Services.ProductServices;
using BabyCareProject.Services.ServiceServices;
using BabyCareProject.Services.TestimonialServices;

namespace BabyCareProject.Extensions
{
    public static class ServiceResgistrations
    {
        public static void AddServiceRegistrations(this IServiceCollection services)
        {
            //IOC Container
            services.AddScoped<IBannerService, BannerService>();
            services.AddScoped<IInstructorService, InstructorService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IAboutService, AboutService>();
            services.AddScoped<IImageService, ImageService>();
           services.AddScoped<IEventService, EventService>();
            services.AddScoped<IServiceService, ServiceService>();
            services.AddScoped<ITestimonialService, TestimonialService>();
            services.AddScoped<IContactService, ContactService>();
           services.AddScoped<ImageUploadHelper>();
        }
    }
}
