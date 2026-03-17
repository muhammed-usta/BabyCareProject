using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.UI.ViewComponents.UILayout
{
    [ViewComponent(Name = "_HeadViewComponent")]

    public class _HeadViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
