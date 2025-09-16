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

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Nome).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Nome).IsRequired().HasMaxLength(200);
                entity.Property(p => p.Preco).HasColumnType("decimal(18,2)");

                entity.HasOne(p => p.Category)
                      .WithMany(c => c.Products)
                      .HasForeignKey(p => p.CategoryId);
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasKey(c => c.Id);

                entity.HasOne(c => c.User)
                      .WithOne(u => u.Cart)
                      .HasForeignKey<Cart>(c => c.UserId);
            });
        }

             private void SeedData(ModelBuilder modelBuilder)
        {
            //Populando dados iniciais para testes
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Nome = "Eletrônicos", Descricao = "Produtos eletrônicos em geral" },
                new Category { Id = 2, Nome = "Roupas", Descricao = "Vestuário masculino e feminino" },
                new Category { Id = 3, Nome = "Casa e Jardim", Descricao = "Produtos para casa e jardim" }
            );

           
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Nome = "Smartphone Samsung", Descricao = "Smartphone com 128GB", Preco = 1299.99m, EstoqueQuantidade = 50, CategoryId = 1 },
                new Product { Id = 2, Nome = "Notebook Dell", Descricao = "Notebook i7 16GB RAM", Preco = 3499.99m, EstoqueQuantidade = 25, CategoryId = 1 },
                new Product { Id = 3, Nome = "Camiseta Polo", Descricao = "Camiseta polo algodão", Preco = 79.99m, EstoqueQuantidade = 100, CategoryId = 2 }
            );

        }
    }
}

