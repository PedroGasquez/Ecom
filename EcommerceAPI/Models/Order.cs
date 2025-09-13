using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceAPI.Models
{
    public enum OrderStatus
    {
        Pendente = 1,
        Processando = 2,
        Enviado = 3,
        Entregue = 4,
        Cancelado = 5
    }

    public class Order
    {
        public int Id { get; set; }

        // FR para User
        public int UserId { get; set; }
        public User User { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        public OrderStatus Status { get; set; } = OrderStatus.Pendente;

        [StringLength(500)]
        public string? EnderecoEntrega { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        
        public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();
    }
}