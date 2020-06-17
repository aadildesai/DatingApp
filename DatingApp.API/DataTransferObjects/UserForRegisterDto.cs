using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.DataTransferObjects
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage = "Username is required")]
        public string Username { get; set; }

        [Required(ErrorMessage = "A password is required")]
        [StringLength(8, MinimumLength = 4, ErrorMessage = "A password should be between 4 and 8 characters")]
        public string Password { get; set; }
    }
}