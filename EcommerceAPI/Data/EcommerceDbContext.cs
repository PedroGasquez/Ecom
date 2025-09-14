using EcommerceAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EcommerceAPI.Data
{
    public class EcommerceDbContext : DbContext
    {
        public EcommerceDbContext(DbContextOptions<EcommerceDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.HasIndex(u => u.Email).IsUnique();
                entity.Property(u => u.Nome).IsRequired().HasMaxLength(100);
                entity.Property(u => u.Email).IsRequired().HasMaxLength(255);

            });
             
        }
    }
}
