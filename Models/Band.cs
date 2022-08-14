#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;

namespace ShowTracker.Models
{
    public class Band
    {
        [Key]
        public int BandId { get; set; }

        [Required(ErrorMessage = "Band name field must not be empty")]
        [MinLength(2, ErrorMessage = "Band name must be at least 2 characters")]
        [Display(Name = "Band Name")]
        public string BandName { get; set; }

        // Timestamps
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<ShowsBand> BandsShows { get; set; }
    }
}