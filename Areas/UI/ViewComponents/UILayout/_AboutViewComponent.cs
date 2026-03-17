using BabyCareProject.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.UI.ViewComponents.UILayout
{
    [ViewComponent( Name= "_AboutViewComponent")]
    public class _AboutViewComponent(IAboutService _aboutService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _aboutService.GetAllAboutAsync();
            ViewBag.videoUrl= values.FirstOrDefault()?.VideoUrl;
            return View(values);  
        }
    }
}
