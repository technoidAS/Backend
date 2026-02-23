using Microsoft.EntityFrameworkCore;
using Backend.Models;

namespace Backend.Config
{
    public class BackendDbContext : DbContext
    {
        public BackendDbContext(DbContextOptions<BackendDbContext> option) : base(option)
        {
            
        }

        public DbSet<UserModal> Users { get; set; }
        public DbSet<AddressModal> Addresses { get; set; }
        public DbSet<ProductModal> Products { get; set; }
        public DbSet<CartModal> Carts { get; set; }
        public DbSet<CartItemModal> CartItems { get; set; }
        public DbSet<OrderModal> Orders { get; set; }
        public DbSet<OrderItemModal> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // User (1) --- (1) Address
            modelBuilder.Entity<UserModal>()
                .HasOne(u => u.Address)
                .WithOne(a => a.User)
                .HasForeignKey<AddressModal>(a => a.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // User (1) --- (1) Cart
            modelBuilder.Entity<UserModal>()
                .HasOne(u => u.Cart)
                .WithOne(c => c.User)
                .HasForeignKey<CartModal>(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // User (1) --- (*) Order
            modelBuilder.Entity<UserModal>()
                .HasMany(u => u.Orders)
                .WithOne(o => o.User)
                .HasForeignKey(o => o.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            // Cart (1) --- (*) CartItem
            modelBuilder.Entity<CartModal>()
                .HasMany(c => c.CartItems)
                .WithOne(ci => ci.Cart)
                .HasForeignKey(ci => ci.CartId)
                .OnDelete(DeleteBehavior.Cascade);

            // CartItem (*) --- (1) Product
            modelBuilder.Entity<CartItemModal>()
                .HasOne(ci => ci.Product)
                .WithMany()
                .HasForeignKey(ci => ci.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            // Order (*) --- (1) Address
            modelBuilder.Entity<OrderModal>()
                .HasOne(o => o.Address)
                .WithMany()
                .HasForeignKey(o => o.AddressId)
                .OnDelete(DeleteBehavior.Restrict);

            // Order (1) --- (*) OrderItem
            modelBuilder.Entity<OrderModal>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade);

            // OrderItem (*) --- (1) Product
            modelBuilder.Entity<OrderItemModal>()
                .HasOne(oi => oi.Product)
                .WithMany()
                .HasForeignKey(oi => oi.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            // Unique constraint on AddressModal.UserId (User can have only 1 Address)
            modelBuilder.Entity<AddressModal>()
                .HasIndex(a => a.UserId)
                .IsUnique();

            // Unique constraint on CartModal.UserId (User can have only 1 Cart)
            modelBuilder.Entity<CartModal>()
                .HasIndex(c => c.UserId)
                .IsUnique();

            // Product table configuration
            modelBuilder.Entity<ProductModal>()
                .Property(p => p.Price)
                .HasPrecision(10, 2);

            // Order table configuration
            modelBuilder.Entity<OrderModal>()
                .Property(o => o.TotalAmount)
                .HasPrecision(10, 2);

            // OrderItem table configuration
            modelBuilder.Entity<OrderItemModal>()
                .Property(oi => oi.PriceAtOrder)
                .HasPrecision(10, 2);
        }
    }
}
