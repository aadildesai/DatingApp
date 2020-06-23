using System;
using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DataTransferObjects
{
    public class UserForRegisterDto
    {
        public UserForRegisterDto()
        {
          Created = DateTime.Now;
          LastActive = DateTime.Now;
        }
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "A password is required")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "A password should be between 4 and 8 characters")]
        public string Password { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string KnownAs { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }
    }
}