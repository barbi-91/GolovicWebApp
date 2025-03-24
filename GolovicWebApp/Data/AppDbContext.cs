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
        public DbSet<ContactMessage> ContactMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PortfolioItem>().HasData(
                new PortfolioItem
                {
                    Id = 1,
                    Name = "Meowtris",
                    Description = "A cat-motivated Tetris game for Windows featuring 20 blocks, standard tetrominoes, and an original BPS scoring system.",
                    ImageUrl = "/images/meowtris.jpg",
                    ProjectUrl = "https://github.com/igolovic/meowtris"
                },
                new PortfolioItem
                {
                    Id = 2,
                    Name = "CmpBin",
                    Description = "Cross-platform GUI desktop application that compares files in two folders based on size and binary content, identifying matches and unique files.",
                    ImageUrl = "/images/cmpbin.jpg",
                    ProjectUrl = "https://github.com/igolovic/cmpbin"
                });
        }
    }
}
