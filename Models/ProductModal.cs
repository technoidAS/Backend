using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class ProductModal
    {
<<<<<<< HEAD
        [Key]
        public int ProductId { get; set; }

        public string ProductName { get; set; } = null!;
        public string? Description { get; set; }

        public string Category { get; set; } = null!;

        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public string? ImageUrl { get; set; }
        public bool IsAvailable { get; set; }

        public DateTime CreatedAt { get; set; }
=======
         public int ProductId { get; set; }
 public string ProductName { get; set; } = null!;
 public string? Description { get; set; }
 public string Category { get; set; } = null!;
 public decimal Price { get; set; }
 public int Quantity { get; set; }
 public string? ImageUrl { get; set; }
 public bool IsAvailable { get; set; }
 public DateTime CreatedAt { get; set; }
>>>>>>> f2e50c97362d5b96799aa3b5f87e3b6c2631ab84
    }
}
