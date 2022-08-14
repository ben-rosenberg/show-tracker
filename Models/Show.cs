//#pragma warning disable CS8618

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowTracker.Models
{
    public class Show
    {
        [Key]
        public int ShowId { get; set; }

        [Required(ErrorMessage = "Please provide the show's venue")]
        [MinLength(2, ErrorMessage = "Venue name must be at least 2 characters")]
        public string Venue { get; set; } = null!;

        [Required(ErrorMessage = "Please provide the city in which the show occurred")]
        [MinLength(3, ErrorMessage = "City name must be at least 3 characters")]
        public string City { get; set; } = null!;
        
        [Required(ErrorMessage = "The state field must not be empty")]
        [MinLength(2, ErrorMessage = "State name must be at least 2 characters")]
        public string State { get; set; } = null!;

        [Required(ErrorMessage = "Please provide the country in which the show occurred")]
        [MinLength(2, ErrorMessage = "Country name must be at least 2 characters")]
        public string Country { get; set; } = null!;

        [Display(Name = "Tour/Show Title")]
        public string Title { get; set; } = null!;

        [Required(ErrorMessage = "Please provide the show's date and time")]
        [Display(Name = "Date and Time")]
        [DataType(DataType.DateTime)]
        public DateTime DateAndTime { get; set; }
        
        [Display(Name = "I played this show")]
        public bool DidUserPlay { get; set; }

        // Timestamps
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        // The user that documented this show.
        public int UserId { get; set; }
        public User UserJoin { get; set; } = null!;

        public List<ShowsBand> ShowsBands { get; set; } = null!;
    }
}