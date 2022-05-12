using SpaDay.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace SpaDay.ViewModels
{
    public class AddUserViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [StringLength(15, MinimumLength = 5, ErrorMessage = "Username must be between 5 and 15 characters long")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Password is too short. Passwords must be at least 6 characters long.")]
        [Compare("VerifyPassword", ErrorMessage = "Password and Verify Password must match!")]
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Verify Password is required")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Sorry, passwords does not matches.")]
        public string VerifyPassword { get; set; }  

        public AddUserViewModel()
        {
            Username = Username;
            Password = Password;
            Email = Email;
            VerifyPassword = VerifyPassword;
        }
    }
}
