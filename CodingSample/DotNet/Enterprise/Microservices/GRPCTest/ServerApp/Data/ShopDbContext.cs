using Microsoft.EntityFrameworkCore;

namespace ServerApp.Data;

public class ShopDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Order> Orders { get; set; }

    public DbSet<Counter> Counters { get; set; }
}
