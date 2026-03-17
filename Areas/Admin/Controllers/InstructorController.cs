using BabyCareProject.DTOs.InstructorDtos;
using BabyCareProject.Services.ImageServices;
using BabyCareProject.Services.InstructorServices;
using Humanizer;
using Microsoft.AspNetCore.Mvc;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class InstructorController(IInstructorService _instructorService, IImageService _imageService, ImageUploadHelper _imageUploadHelper) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _instructorService.GetAllInstructorAsync();
            return View(values);
        }

        public async Task<IActionResult> CreateInstructor()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateInstructor(CreateInstructorDto dto)
        {
            var result = await _imageUploadHelper.TryUploadIfExistsAsync(dto);

            if (!result.isSuccess)
            {
                ModelState.AddModelError(string.Empty, result.errorMessage);
                return View(dto);
            }
            await _instructorService.CreateInstructorAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeleteInstructor(string id)
        {
            await _instructorService.DeleteInstructorAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateInstructor(string id)
        {
            var value = await _instructorService.GetInstructorByIdAsync(id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateInstructor(UpdateInstructorDto dto)
        {
            var result = await _imageUploadHelper.TryUploadIfExistsAsync(dto);

            if (!result.isSuccess)
            {
                ModelState.AddModelError(string.Empty, result.errorMessage);
                return View(dto);
            }
            await _instructorService.UpdateInstructorAsync(dto);
            return RedirectToAction(nameof(Index));
        }


    }
}
