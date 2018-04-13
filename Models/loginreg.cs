using System.ComponentModel.DataAnnotations;

namespace loginreg.Models
{
    public class User
    {
        [Display(Name = "First Name")]
        [Required]
        [MinLength(2, ErrorMessage="First name must be more than 4 characters long")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [MinLength(2, ErrorMessage="Last name must be more than 4 characters long")]
        public string LastName { get; set; }

        [Display(Name = "Email")]
        [Required]
        [EmailAddress()]
        public string Email { get; set; }
        
        [Display(Name ="Password")]
        [Required]
        [MinLength(8, ErrorMessage="Password must be more than 8 characters long")]
        public string Password { get; set; }
        
        [Display(Name = "Confirm Password")]
        [Required]
        [Compare("Password", ErrorMessage="Password is not matching, Please try again.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginUser
    {
        [Display(Name = "Email")]
        [Required]
        [EmailAddress()]
        public string Email { get; set; }
        [Display(Name ="Password")]
        [Required]
        public string Password { get; set; }
    }
}