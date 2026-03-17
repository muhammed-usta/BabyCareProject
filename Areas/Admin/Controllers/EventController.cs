using BabyCareProject.DTOs.BannerDtos;
using BabyCareProject.DTOs.EventDtos;
using BabyCareProject.Services.EventServices;
using BabyCareProject.Services.ImageServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EventController (IEventService _eventService,IImageService _imageService,ImageUploadHelper _imageUploadHelper): Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _eventService.GetAllEventAsync();
            return View(values);
        }

        public async Task<IActionResult> CreateEvent()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> CreateEvent(CreateEventDto dto)
        {
            var result = await _imageUploadHelper.TryUploadIfExistsAsync(dto);

            if (!result.isSuccess)
            {
                ModelState.AddModelError(string.Empty, result.errorMessage);
                return View(dto);
            }
       

            await _eventService.CreateEventAsync(dto);
            return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> UpdateEvent(string id)
        {
            var values = await _eventService.GetEventByIdAsync(id);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateEvent(UpdateEventDto dto)
        {

            var result = await _imageUploadHelper.TryUploadIfExistsAsync(dto);

            if (!result.isSuccess)
            {
                ModelState.AddModelError(string.Empty, result.errorMessage);
                return View(dto);
            }

            await _eventService.UpdateEventAsync(dto);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> DeleteEvent(string id)
        {
            await _eventService.DeleteEventAsync(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
