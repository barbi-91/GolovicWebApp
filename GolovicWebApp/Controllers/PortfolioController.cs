using GolovicWebApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GolovicWebApp.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly AppDbContext _context;
        public PortfolioController(AppDbContext context)
        {
                _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var portfolioItems = await _context.PortfolioItems.ToListAsync();
            return View(portfolioItems);
        }
    }
}
