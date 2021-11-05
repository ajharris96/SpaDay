using System;
using SpaDay;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {

        [Required(ErrorMessage = "Username is required.")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Name must be between 5 and 15 characters.")]
        public string Username { get; set; }

        [EmailAddress(ErrorMessage ="Must be a proper email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 6, ErrorMessage ="Password must be between 6 and 20 characters.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Verify Password")]
        [Compare("Password", ErrorMessage = "Passwords must match")]
        //[StringLength(20, MinimumLength = 6, ErrorMessage = "Password must be between 6 and 20 characters.")]
        public string VerifyPassword { get; set; }

        public AddUserViewModel()
        {
        }
    }
}
