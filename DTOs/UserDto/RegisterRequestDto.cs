using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs.UserDto
{
    public class RegisterRequestDto
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
