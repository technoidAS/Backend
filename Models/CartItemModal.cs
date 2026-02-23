using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class CartItemModal
    {
<<<<<<< HEAD
        [Key]
        public int CartItemId { get; set; }

        public int CartId { get; set; }
        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public CartModal Cart { get; set; } = null!;
        public ProductModal Product { get; set; } = null!;
=======
            public int CartItemId { get; set; }
    public int CartId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public CartModal Cart { get; set; } = null!;
    public ProductModal Product { get; set; } = null!;
}
>>>>>>> f2e50c97362d5b96799aa3b5f87e3b6c2631ab84
    }
}
