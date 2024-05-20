using Microsoft.EntityFrameworkCore;
using Server_API.Models;
public class UserDBContext : DbContext
    {
    public string DbPath {  get; set; }
    public UserDBContext(DbContextOptions<UserDBContext> options)
    : base(options)
    {
    }

    public DbSet<User> khachhang { get; set; }
    public DbSet<PW> Passwords { get; set; }

    //protected override void OnConfiguring(DbContextOptionsBuilder options)
    //=> options.UseSqlite($"Data Source={DbPath}");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<User>().ToTable("khachhang");
        modelBuilder.Entity<PW>().ToTable("KhongPhaiMatKhau");
        modelBuilder.Entity<PW>()
            .HasKey(p=>p.salt);
        modelBuilder.Entity<User>()
            .HasKey(u => u.ID_KhachHang);

        modelBuilder.Entity<User>()
            .HasOne(u => u.PW)
            .WithOne(p => p.User)
            .HasForeignKey<PW>(p => p.ID_KhachHang);    // Configuring Foreign key

    }
}
