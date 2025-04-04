﻿using System.ComponentModel.DataAnnotations;

namespace GolovicWebApp.Models
{
    public class PortfolioItem
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        public string? ImageUrl { get; set; }

        public string? ProjectUrl { get; set; }
    }
}
