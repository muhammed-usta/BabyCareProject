using BabyCareProject.Services.ContactServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.UI.ViewComponents.UILayout
{
    [ViewComponent(Name = "_NavbarViewComponent")]

    public class _NavbarViewComponent(IContactService _contactService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = (await _contactService.GetAllContactAsync()).FirstOrDefault();
            return View(values);
        }
    }
}
