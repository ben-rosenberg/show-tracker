#pragma warning disable CS8618

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShowTracker.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "The first name field must not be empty")]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "The last name field must not be empty")]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "The username field must not be empty")]
        [MinLength(6, ErrorMessage = "Username must be at least 6 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "The email field must not be empty")]
        [EmailAddress]
        // [NewEmail]
        public string Email { get; set; }

        // TODO: RegEx validation for password characters
        [Required(ErrorMessage = "The password field must not be empty")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [NotMapped]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public List<Show> UsersShows { get; set; }
    }

    // TODO
    public class NewEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            return base.IsValid(value, validationContext);
        }
    }
}