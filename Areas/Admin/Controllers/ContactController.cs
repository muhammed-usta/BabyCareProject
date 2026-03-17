using BabyCareProject.DTOs.ContactDtos;
using BabyCareProject.DTOs.ServiceDtos;
using BabyCareProject.Services.ContactServices;
using BabyCareProject.Services.ImageServices;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BabyCareProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController(IContactService _contactService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values= await _contactService.GetAllContactAsync();
            return View(values);
        }

        public async Task<IActionResult> CreateContact()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDto dto)
        {

            await _contactService.CreateContactAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> UpdateContact(string id)
        {
            var values = await _contactService.GetContactByIdAsync(id);
            return View(values);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateContact(UpdateContactDto dto)
        {

           
            await _contactService.UpdateContactAsync(dto);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeleteContact(string id)
        {
            await _contactService.DeleteContactAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
   
    }
