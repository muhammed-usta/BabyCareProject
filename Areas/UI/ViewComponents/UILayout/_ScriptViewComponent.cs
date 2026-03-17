using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.UI.ViewComponents.UILayout
{
    [ViewComponent (Name = "_ScriptViewComponent")]
    public class _ScriptViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
