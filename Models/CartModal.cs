using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class CartModal
    {
<<<<<<< HEAD
        [Key]
        public int CartId { get; set; }

        public int UserId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }

=======
                public int CartId { get; set; }
        public int UserId { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
>>>>>>> f2e50c97362d5b96799aa3b5f87e3b6c2631ab84
        public UserModal User { get; set; } = null!;
        public ICollection<CartItemModal> CartItems { get; set; } = new List<CartItemModal>();
    }
}
