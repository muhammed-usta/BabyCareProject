using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.UI.Controllers
{
    [Area("UI")]
    public class UIController : Controller
    {
        public IActionResult UILayout()
        {
            return View();
        }
    }
}
