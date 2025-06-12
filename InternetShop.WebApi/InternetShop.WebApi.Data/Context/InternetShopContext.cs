using InternetShop.WebApi.Data.Entities;
using Microsoft.EntityFrameworkCore;


namespace InternetShop.WebApi.Data.Context
{
    public class InternetShopContext : DbContext
    {
        public InternetShopContext(DbContextOptions<InternetShopContext> options) : base(options) { }

        public virtual DbSet<Category> Category { get; set; }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<CartItem> CartItem { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                .HasKey(od => new { od.OrderId, od.ProductId });

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Order)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(od => od.OrderId);

            modelBuilder.Entity<OrderDetail>()
                .HasOne(od => od.Product)
                .WithMany(p => p.OrderDetails)
                .HasForeignKey(od => od.ProductId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
