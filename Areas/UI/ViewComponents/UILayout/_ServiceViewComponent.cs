using BabyCareProject.Services.ServiceServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.UI.ViewComponents.UILayout
{
    [ViewComponent(Name = "_ServiceViewComponent")]
    public class _ServiceViewComponent(IServiceService _serviceService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _serviceService.GetAllServiceAsync();

            return View(values);
        }
    }
}
