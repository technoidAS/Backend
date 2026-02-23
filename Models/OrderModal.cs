namespace Backend.Models
{
    public class OrderModal
    {
      public int OrderId { get; set; }
public int UserId { get; set; }
public int AddressId { get; set; }
public DateTime OrderDate { get; set; }
public decimal TotalAmount { get; set; }
public string Status { get; set; } = null!;
public bool IsPaid { get; set; }
public UserModal User { get; set; } = null!;
public ICollection<OrderItemModal> OrderItems { get; set; } = new List<OrderItemModel>();
public AddressModal Address { get; set; } = null!;  
    }
}
