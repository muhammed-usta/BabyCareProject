using BabyCareProject.DTOs.Interfaces;
using BabyCareProject.DTOs.ProductDtos;
using BabyCareProject.Services.ImageServices;
using BabyCareProject.Services.InstructorServices;
using BabyCareProject.Services.ProductServices;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController(IProductService _productService, IInstructorService _instructorService, IImageService _imageService, ImageUploadHelper _imageUploadHelper) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _productService.GetAllAsync();
            return View(values);
        }

        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CreateProduct()
        {
            
            var instructors = await _instructorService.GetAllInstructorAsync();
            ViewBag.Instructors = (from x in instructors
                                   select new SelectListItem
                                   {
                                       Text = x.FullName,
                                       Value = x.FullName
                                   }).ToList();
            return View();

        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto dto)
        {
            var result = await _imageUploadHelper.TryUploadIfExistsAsync(dto);

            if (!result.isSuccess)
            {
                ModelState.AddModelError(string.Empty, result.errorMessage);
                return View(dto);
            }
            await _productService.CreateAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateProduct(string id)
        {
            var instructors = await _instructorService.GetAllInstructorAsync();
            ViewBag.Instructors = (from x in instructors
                                   select new SelectListItem
                                   {
                                       Text = x.FullName,
                                       Value = x.FullName
                                   }).ToList();

            var value = await _productService.GetById(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto dto)
        {
            var result = await _imageUploadHelper.TryUploadIfExistsAsync(dto);

            if (!result.isSuccess)
            {
                ModelState.AddModelError(string.Empty, result.errorMessage);
                return View(dto);
            }
            await _productService.UpdateAsync(dto);
            return RedirectToAction(nameof(Index));
        }


    }
}
