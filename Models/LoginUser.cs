#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;

namespace ShowTracker.Models
{
    public class LoginUser
    {
        [Required(ErrorMessage = "The email field must not be empty")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string LoginEmail { get; set; }

        [Required(ErrorMessage = "The password field must not be empty")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string LoginPassword { get; set; }
    }
}