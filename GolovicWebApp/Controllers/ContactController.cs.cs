using GolovicWebApp.Data;
using GolovicWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace GolovicWebApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        public ContactController(AppDbContext context)
        {
                _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // POST: Contact
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index([Bind("Name,Email,Message")] ContactMessage contactMessage)
        {

            // Provjeri što dolazi u modelu
            Console.WriteLine($"Name: {contactMessage.Name}, Email: {contactMessage.Email}, Message: {contactMessage.Message}");

            if (contactMessage == null)
            {
                return BadRequest("Invalid contact message.");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.ContactMessages.Add(contactMessage);
                    await _context.SaveChangesAsync();
                    TempData["Message"] = "Your message has been sent successfully";
                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    TempData["Message"] = "Error: " + ex.Message;
                }
            }
            else
            {
                TempData["Message"] = "Form is not valid.";
            }

            return View();
        }
    }
}
