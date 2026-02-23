using System.ComponentModel.DataAnnotations;

namespace Backend.DTOs.UserDto
{
    public class UpdateUserDto
    {
        [Required]
        public string UserName { get; set; } = null!;
        
        [EmailAddress]
        public string Email { get; set; } = null!;
        
        public string MobileNo { get; set; } = null!;
    }
}
