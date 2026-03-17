using BabyCareProject.DTOs.TestimonialDtos;
using BabyCareProject.Services.ImageServices;
using BabyCareProject.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController(ITestimonialService _testimonialService, IImageService _imageService, ImageUploadHelper _imageUploadHelper) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values= await _testimonialService.GetAllTestimonialAsync();
            return View(values);
        }
        public async Task<IActionResult> CreateTestimonial()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonial(CreateTestimonialDto dto)
        {
            var result = await _imageUploadHelper.TryUploadIfExistsAsync(dto);

            if (!result.isSuccess)
            {
                ModelState.AddModelError(string.Empty, result.errorMessage);
                return View(dto);
            }


            await _testimonialService.CreateTestimonialAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateTestimonial(string id)
        {
            var values = await _testimonialService.GetTestimonialByIdAsync(id);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateTestimonial(UpdateTestimonialDto dto)
        {

            var result = await _imageUploadHelper.TryUploadIfExistsAsync(dto);

            if (!result.isSuccess)
            {
                ModelState.AddModelError(string.Empty, result.errorMessage);
                return View(dto);
            }

            await _testimonialService.UpdateTestimonialAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeleteTestimonial(string id)
        {
            await _testimonialService.DeleteTestimonialAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
