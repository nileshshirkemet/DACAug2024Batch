using Microsoft.EntityFrameworkCore;
using Sales;

namespace Shopping.Data;

public class ShopDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .ToTable("ProductInfo")
            .Property(p => p.Id)
            .HasColumnName("ProductNo");
        modelBuilder.Entity<Order>()
            .ToTable("OrderDetail")
            .Property(p => p.Id)
            .HasColumnName("OrderNo");
        modelBuilder.Entity<Order>()
            .Property(p => p.ProductId)
            .HasColumnName("ProductNo");
    }
}