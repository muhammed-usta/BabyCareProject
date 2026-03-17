using BabyCareProject.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.UI.ViewComponents.UILayout
{
    [ViewComponent (Name ="_ProductViewComponent")]
    public class _ProductViewComponent(IProductService _productService):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values= await _productService.GetAllAsync();
               return View(values);   
        }
    }
}
