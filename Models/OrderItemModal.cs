namespace Backend.Models
{
    public class OrderItemModal
    {
         public int OrderItemId { get; set; }
 public int OrderId { get; set; }
 public int ProductId { get; set; }
 public int Quantity { get; set; }
 public decimal PriceOrder { get; set; }
 public OrderModal Order { get; set; }
 public ProductModal Product { get; set; }
    }
}
