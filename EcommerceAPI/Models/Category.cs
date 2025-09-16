using System.ComponentModel.DataAnnotations;

namespace EcommerceAPI.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(500)]
        public string? Descricao { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}