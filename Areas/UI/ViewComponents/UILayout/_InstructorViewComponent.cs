using BabyCareProject.Services.InstructorServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.UI.ViewComponents.UILayout
{
    [ViewComponent(Name = "_InstructorViewComponent")]
    public class _InstructorViewComponent(IInstructorService _instructorService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _instructorService.GetAllInstructorAsync();
            return View(values);
        }
    }
}
