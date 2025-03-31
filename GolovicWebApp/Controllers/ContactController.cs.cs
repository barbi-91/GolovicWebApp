using GolovicWebApp.Data;
using GolovicWebApp.Models;
using GolovicWebApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace GolovicWebApp.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _context;
        private readonly EmailService _emailService;
        public ContactController(AppDbContext context, EmailService emailService)
        {
            _context = context;
            _emailService = emailService;
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
                    // Send email
                    var subject = "New Contact Message";
                    var body = $"You have received a new message from: {contactMessage.Name}({contactMessage.Email}), message: {contactMessage.Message}";

                    await _emailService.SendEmailAsync(subject, body);  


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
