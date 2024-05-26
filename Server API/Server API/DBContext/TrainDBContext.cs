using Microsoft.EntityFrameworkCore;
using Server_API.Models;

namespace Server_API.DBContext
{
    public class TrainDBContext : DbContext
    {
        public TrainDBContext(DbContextOptions<TrainDBContext> options) : base(options) { } 
        public DbSet <Tau> Tau {  get; set; }
        public DbSet <Toa> Toa { get; set; }
        public DbSet <Ghe> Ghe { get; set; }
        public DbSet <Phong> Phong { get; set; }
        public DbSet <Giuong> Giuong { get; set; }
        public DbSet <Tram> Tram { get; set; }
        public DbSet <Tuyen> Tuyen { get; set; }
        public DbSet <DiemDi> DiemDi { get; set; }
        public DbSet <LichTrinh> LichTrinh { get; set; }
        public DbSet <VeNgoi> VeNgoi { get; set; }
        public DbSet <VeNam> VeNam { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tau>().ToTable("Tau");  // =====Tau=====
            modelBuilder.Entity<Tau>()
                .HasKey(t => t.ID_Tau);

            modelBuilder.Entity<Toa>().ToTable("Toa");  // =====Toa=====
            modelBuilder.Entity<Toa>()
                .HasKey(t => t.ID_Toa);
            modelBuilder.Entity<Toa>()                  // Toa n - 1 Tau
                .HasOne(t => t.Tau)
                .WithMany(t => t.Toa)
                .HasForeignKey(t => t.ID_Tau);

            modelBuilder.Entity<Ghe>().ToTable("Ghe");  // =====Ghe=====
            modelBuilder.Entity<Ghe>()
                .HasKey(g => new { g.ID_Ghe, g.ID_Toa });
            modelBuilder.Entity<Ghe>()                  // Ghe n - 1 toa
                .HasOne(g => g.Toa)
                .WithMany(g => g.Ghe)
                .HasForeignKey(g => g.ID_Toa);

            modelBuilder.Entity<Phong>().ToTable("Phong");  // =====Phong=====
            modelBuilder.Entity<Phong>()
                .HasKey(p => p.ID_Phong);
            modelBuilder.Entity<Phong>()                    // Phong n - 1 toa
                .HasOne(t => t.Toa)
                .WithMany(p => p.Phong)
                .HasForeignKey(t => t.ID_Toa);

            modelBuilder.Entity<Giuong>().ToTable("Giuong");    // =====Giuong=====
            modelBuilder.Entity <Giuong>()
                .HasKey(g => new { g.ID_Giuong, g.ID_Phong });
            modelBuilder.Entity<Giuong>()                       // Giuong n - 1 phong
                .HasOne(p => p.Phong)
                .WithMany(g => g.Giuong)
                .HasForeignKey(g => g.ID_Phong);


            modelBuilder.Entity<Tram>().ToTable("Tram");        // =====Tram=====
            modelBuilder.Entity<Tram>()
                .HasKey(t => t.ID_Tram);

            modelBuilder.Entity<Tuyen>().ToTable("Tuyen");      // =====Tuyen=====
            modelBuilder.Entity<Tuyen>()
                .HasKey(t => t.ID_Tuyen);

            modelBuilder.Entity<DiemDi>().ToTable("DiemDi");    // =====Diem di===== { Tram 1 - n DiemDi n - 1 Tuyen }
            modelBuilder.Entity<DiemDi>()
                .HasKey(dd => new { dd.ID_Tuyen, dd.ID_Tram });
            modelBuilder.Entity<DiemDi>()                       // DiemDi n - 1 Tuyen
                .HasOne(dd => dd.Tuyen)
                .WithMany(t => t.DiemDi)
                .HasForeignKey(dd => dd.ID_Tuyen);
            modelBuilder.Entity<DiemDi>()                       // DiemDi n - 1 Tram
                .HasOne(dd => dd.Tram)
                .WithMany(t => t.DiemDi)
                .HasForeignKey(dd => dd.ID_Tram);

            modelBuilder.Entity<LichTrinh>().ToTable("LichTrinh");  // =====Lich trinh ===== { Tau 1 - n Lich trinh n - 1 Tuyen }
            modelBuilder.Entity<LichTrinh>()
                .HasKey(lt => lt.ID_LichTrinh);
            modelBuilder.Entity<LichTrinh>()                        // Lich trinh n - 1 tuyen
                .HasOne(t => t.Tuyen)
                .WithMany(lt => lt.LichTrinh)
                .HasForeignKey(lt => lt.ID_Tuyen);
            modelBuilder.Entity<LichTrinh>()                        // Lich trinh n - 1 tau
                .HasOne(t => t.Tau)
                .WithMany(lt => lt.LichTrinh)
                .HasForeignKey(lt => lt.ID_Tau);
            modelBuilder.Entity<LichTrinh>()                        // Setting nullable cho thu trong tuan
                .Property(lt => lt.Thu)
                .HasConversion(
                    lt => lt.HasValue ? lt.ToString() : null,
                    lt => lt != null ? (DayOfWeek?)Enum.Parse(typeof(DayOfWeek), lt) : null);

            modelBuilder.Entity<VeNgoi>().ToTable("VeNgoi");    // =====VeNgoi=====
            modelBuilder.Entity<VeNgoi>()
                .HasKey(v => v.ID_VeNgoi);
            modelBuilder.Entity<VeNgoi>()                       // Ve ngoi 1 - 1 ghe
                .HasOne(g => g.Ghe)
                .WithOne(v => v.VeNgoi)
                .HasForeignKey<VeNgoi>(v => new { v.ID_Ghe, v.ID_Toa })
                .HasPrincipalKey<Ghe>(g => new { g.ID_Ghe, g.ID_Toa});
            modelBuilder.Entity<VeNgoi>()
                .HasOne(v => v.LichTrinh)
                .WithMany()
                .HasForeignKey(v => v.ID_LichTrinh);
            modelBuilder.Entity<VeNam>().ToTable("VeNam");      // =====VeNam=====
            modelBuilder.Entity<VeNam>()
                .HasKey(v => v.ID_VeNam);
            modelBuilder.Entity<VeNam>()                        // Ve nam 1 - 1 giuong
                .HasOne(g => g.Giuong)
                .WithOne(v => v.VeNam)
                .HasForeignKey<VeNam>(v => new { v.ID_Giuong, v.ID_Phong })
                .HasPrincipalKey<Giuong>(g => new { g.ID_Giuong, g.ID_Phong });
            modelBuilder.Entity<VeNam>()                        // Ve nam n - 1 tuyen
                .HasOne(v => v.LichTrinh)
                .WithMany()
                .HasForeignKey(v => v.ID_LichTrinh);
        }
    }
}
