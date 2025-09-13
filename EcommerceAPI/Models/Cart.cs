using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Models
{
    public class Cart
    {
        public int Id { get; set; }

        // FR para User
        public int UserId { get; set; }
        public User User { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        
        public ICollection<CartItem> Items { get; set; } = new List<CartItem>();

        [NotMapped]
        public decimal Total => Items?.Sum(i => i.Preco * i.Quantidade) ?? 0;
    }
}