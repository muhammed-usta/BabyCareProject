using BabyCareProject.DTOs.AboutDtos;
using BabyCareProject.DTOs.ServiceDtos;
using BabyCareProject.Services.ImageServices;
using BabyCareProject.Services.ServiceServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController(IServiceService _serviceService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _serviceService.GetAllServiceAsync();
            return View(values);
        }

        public async Task<IActionResult> CreateService()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateService(CreateServiceDto dto)
        {

            await _serviceService.CreateServiceAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateService(string id)
        {
            var values = await _serviceService.GetServiceByIdAsync(id);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateService(UpdateServiceDto dto)
        {

            await _serviceService.UpdateServiceAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeleteService(string id)
        {
            await _serviceService.DeleteServiceByIdAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }


}
