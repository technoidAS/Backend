namespace Backend.Models
{
    public class AddressModal
    {
       public int AddressId { get; set; }
 public int UserId { get; set; }
 public string Line1 { get; set; } = null!;
 public string City { get; set; } = null!;
 public string Pincode { get; set; } = null!;
 public UserModal User { get; set; } = null!;
    }
}
