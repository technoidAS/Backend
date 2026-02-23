using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class OrderItemModal
    {
<<<<<<< HEAD
        [Key]
        public int OrderItemId { get; set; }

        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }
        public decimal PriceAtOrder { get; set; }

        public OrderModal Order { get; set; } = null!;
        public ProductModal Product { get; set; } = null!;
=======
         public int OrderItemId { get; set; }
 public int OrderId { get; set; }
 public int ProductId { get; set; }
 public int Quantity { get; set; }
 public decimal PriceOrder { get; set; }
 public OrderModal Order { get; set; }
 public ProductModal Product { get; set; }
>>>>>>> f2e50c97362d5b96799aa3b5f87e3b6c2631ab84
    }
}
