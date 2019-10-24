using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PTCGUltraFanClub.Models
{
    public class User
    {
        public int UserID { get; set; }

        public string Username { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [EmailAddress]
        public string EmailAddresss { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [StringLength(30, ErrorMessage = "Must be between 5 and 30 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required")]
        [StringLength(30, ErrorMessage = "Must be between 5 and 30 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public UserDeckChoice userDeckChoices { get; set; }
    }
}
