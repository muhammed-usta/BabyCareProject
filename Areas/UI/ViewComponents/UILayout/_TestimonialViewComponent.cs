using BabyCareProject.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.UI.ViewComponents.UILayout
{
    [ViewComponent (Name = "_TestimonialViewComponent")]
    public class _TestimonialViewComponent(ITestimonialService _testimonialService):ViewComponent
    {
       public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _testimonialService.GetAllTestimonialAsync();
            return View(values);
        }
    }
}
