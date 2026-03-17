using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.UI.ViewComponents.UILayout
{
    [ViewComponent (Name = "_CopyrightViewComponent")]
    public class _CopyrightViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        { 
            return View(); 
        } 
    }
}
