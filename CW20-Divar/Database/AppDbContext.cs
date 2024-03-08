using CW20.Models;
using Microsoft.EntityFrameworkCore;

namespace CW20.Database;

public class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-BKH8GT2\SQLEXPRESS;Integrated Security=true;Database=CW20;TrustServerCertificate=True;");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Ad> Ads { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Picture> Picture { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Bookmark> Bookmarks { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new CityConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
    }
}
