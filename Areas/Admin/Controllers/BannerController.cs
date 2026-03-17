using BabyCareProject.DTOs.AboutDtos;
using BabyCareProject.DTOs.BannerDtos;
using BabyCareProject.Services.BannerServices;
using BabyCareProject.Services.ImageServices;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController(IBannerService _bannerService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _bannerService.GetAllBannerAsync();
            return View(values);
        }

        public async Task<IActionResult> CreateBanner()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateBanner(CreateBannerDto dto)
        {
            await _bannerService.CreateBannerAsync(dto);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> UpdateBanner(string id)
        {
            var values = await _bannerService.GetBannerByIdAsync(id);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateBanner(UpdateBannerDto dto)
        {


            await _bannerService.UpdateBannerAsync(dto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> DeleteBanner(string id)
        {
            await _bannerService.DeleteBannerAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
