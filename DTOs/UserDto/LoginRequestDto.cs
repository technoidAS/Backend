using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs.UserDto
{
    public class LoginRequestDto
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
