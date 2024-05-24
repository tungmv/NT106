using Microsoft.EntityFrameworkCore;
using Server_API.Models;
public class UserDBContext : DbContext
{
    public string DbPath { get; set; }
    public UserDBContext(DbContextOptions<UserDBContext> options)
    : base(options)
    {
    }

    public DbSet<User> khachhang { get; set; }
    public DbSet<PW> Passwords { get; set; }

    public DbSet<LichSuDatVeNam> LichSuDatVeNam { get; set; }
    public DbSet<LichSuDatVeNgoi> LichSuDatVeNgoi { get; set; }

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
            .HasOne(p => p.PW)
            .WithOne(u => u.User)
            .HasForeignKey<PW>(p => p.ID_KhachHang);    // Configuring Foreign key khachhang -> password

        modelBuilder.Entity<LichSuDatVeNgoi>()
            .HasKey(v => new { v.ID_KhachHang, v.ID_VeNgoi });

        modelBuilder.Entity<LichSuDatVeNam>()
    .HasKey(v => new { v.ID_KhachHang, v.ID_VeNam });

        modelBuilder.Entity<LichSuDatVeNgoi>().ToTable("LichSuDatVeNgoi");
        modelBuilder.Entity<LichSuDatVeNam>().ToTable("LichSuDatVeNam");
        modelBuilder.Entity<User>()
            .HasMany(v => v.LichSuDatVeNgoi)
            .WithOne(u => u.User)
            .HasForeignKey(u => u.ID_KhachHang);
        modelBuilder.Entity<User>()
            .HasMany(v => v.LichSuDatVeNam)
            .WithOne(u => u.User)
            .HasForeignKey(u => u.ID_KhachHang);
    }
}
