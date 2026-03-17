using BabyCareProject.Services.ContactServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.UI.ViewComponents.UILayout
{
    [ViewComponent(Name = "_FooterViewComponent")]
    public class _FooterViewComponent(IContactService _contactService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var contact = (await _contactService.GetAllContactAsync()).FirstOrDefault();
            return View(contact);
        }
    }
}
