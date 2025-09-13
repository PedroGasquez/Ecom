using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        // FR para Cart
        public int CartId { get; set; }
        public Cart Cart { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantidade { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; } 

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [NotMapped]
        public decimal Subtotal => Preco * Quantidade;
    }
}