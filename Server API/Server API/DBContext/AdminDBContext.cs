using Microsoft.EntityFrameworkCore;
using Server_API.Models;
public class AdminDBContext : DbContext
{
    public AdminDBContext(DbContextOptions<AdminDBContext> options) : base (options)
    {
    }

    public DbSet<Admin> Admin { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Admin>().ToTable("Admin");
        modelBuilder.Entity<Admin>().HasKey(a => a.ID);
    }
}
