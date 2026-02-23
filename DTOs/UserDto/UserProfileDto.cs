namespace Backend.DTOs.UserDto
{
    public class UserProfileDto
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string MobileNo { get; set; } = null!;
        public bool IsAdmin { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
