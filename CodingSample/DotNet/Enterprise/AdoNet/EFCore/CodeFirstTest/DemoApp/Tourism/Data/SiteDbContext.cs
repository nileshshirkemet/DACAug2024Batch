using Microsoft.EntityFrameworkCore;

namespace Tourism.Data;

public class SiteDbContext : DbContext
{
    public DbSet<Traveler> Travelers { get; set; }

    public SiteDbContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=site.db");
    }
}