using BabyCareProject.DTOs.AboutDtos;
using BabyCareProject.DTOs.ProductDtos;
using BabyCareProject.Services.AboutServices;
using BabyCareProject.Services.ImageServices;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController(IAboutService _aboutService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _aboutService.GetAllAboutAsync();
            return View(values);
        }

        public async Task<IActionResult> CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateAbout(CreateAboutDto dto)
        {
            await _aboutService.CreateAboutAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateAbout(string id)
        {
            var values = await _aboutService.GetAboutByIdAsync(id);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto dto)
        {

            await _aboutService.UpateAboutAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeleteAbout(string id)
        {
            await _aboutService.DeleteAboutAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
