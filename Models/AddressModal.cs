using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class AddressModal
    {
<<<<<<< HEAD
        [Key]
        public int AddressId { get; set; }

        public int UserId { get; set; }

        public string AddressDetail { get; set; } = null!;
        public string City { get; set; } = null!;

        public string State { get; set; } = null!;
        public string Pincode { get; set; } = null!;

        public UserModal User { get; set; } = null!;
=======
       public int AddressId { get; set; }
 public int UserId { get; set; }
 public string Line1 { get; set; } = null!;
 public string City { get; set; } = null!;
 public string Pincode { get; set; } = null!;
 public UserModal User { get; set; } = null!;
>>>>>>> f2e50c97362d5b96799aa3b5f87e3b6c2631ab84
    }
}
