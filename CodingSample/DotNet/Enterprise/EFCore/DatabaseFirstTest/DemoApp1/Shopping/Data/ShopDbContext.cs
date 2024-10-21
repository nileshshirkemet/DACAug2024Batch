using Microsoft.EntityFrameworkCore;

namespace Shopping.Data;

public class ShopDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=iitdac.met.edu;Database=Shop;User Id=dac;Password=Dac@1234;Encrypt=False");
    }
}
