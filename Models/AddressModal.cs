using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class AddressModal
    {
        [Key]
        public int AddressId { get; set; }

        public int UserId { get; set; }

        public string AddressDetail { get; set; } = null!;
        public string City { get; set; } = null!;

        public string State { get; set; } = null!;
        public string Pincode { get; set; } = null!;

        public UserModal User { get; set; } = null!;
    }
}
