using BabyCareProject.Services.EventServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.UI.ViewComponents.UILayout
{
    [ViewComponent (Name = "_EventViewComponent")]
    public class _EventViewComponent(IEventService _eventService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _eventService.GetAllEventAsync();
            return View(values);

        }
    }
}
