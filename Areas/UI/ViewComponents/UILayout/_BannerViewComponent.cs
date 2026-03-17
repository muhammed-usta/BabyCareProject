using BabyCareProject.Services.BannerServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.UI.ViewComponents.UILayout
{
    [ViewComponent(Name = "_BannerViewComponent")]

    public class _BannerViewComponent(IBannerService _bannerService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
          var values=  await _bannerService.GetAllBannerAsync();
            return View(values);  
        }
    }
}
