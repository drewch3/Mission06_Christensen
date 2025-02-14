
using System.ComponentModel.DataAnnotations;

namespace MissionO6_Christensen.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; } // Primary Key
        
        [Required]
        public string Title { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string Rating { get; set; } // Dropdown (G, PG, PG-13, R)

        public bool Edited { get; set; } = false; // Default to false

        public string? LentTo { get; set; } // Optional

        [MaxLength(25)]
        public string? Notes { get; set; } // Optional, max 25 chars
    }
}
