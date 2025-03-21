using Microsoft.AspNetCore.Mvc;

namespace GolovicWebApp.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
