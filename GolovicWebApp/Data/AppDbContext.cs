using Microsoft.EntityFrameworkCore;
using GolovicWebApp.Models;

namespace GolovicWebApp.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<PortfolioItem>PortfolioItems { get; set; }
    }
}
