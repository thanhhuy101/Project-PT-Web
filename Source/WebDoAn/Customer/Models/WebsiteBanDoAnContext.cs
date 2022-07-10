using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Customer.Models
{
    public partial class WebsiteBanDoAnContext : DbContext
    {
        public WebsiteBanDoAnContext()
        {
        }

        public WebsiteBanDoAnContext(DbContextOptions<WebsiteBanDoAnContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<ChiTietHoaDon> ChiTietHoaDons { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<DanhGium> DanhGia { get; set; }
        public virtual DbSet<GioHang> GioHangs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<MonAn> MonAns { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=DESKTOP-R4QBP5J;user Id=sa;password=1;database=WebsiteBanDoAn");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.MaLoai);

                entity.ToTable("Category");

                entity.Property(e => e.TenLoai).HasMaxLength(50);
            });

            modelBuilder.Entity<ChiTietHoaDon>(entity =>
            {
                entity.HasKey(e => e.MaCt);

                entity.ToTable("Chi tiet hoa don");

                entity.Property(e => e.MaCt).HasColumnName("MaCT");

                entity.Property(e => e.Gia).HasColumnType("money");

                entity.Property(e => e.MaHd).HasColumnName("MaHD");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.HasOne(d => d.MaHdNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaHd)
                    .HasConstraintName("FK_Chi tiet hoa don_HoaDon");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.ChiTietHoaDons)
                    .HasForeignKey(d => d.MaSp)
                    .HasConstraintName("FK_Chi tiet hoa don_MonAn");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact");

                entity.Property(e => e.Contents).HasColumnName("contents");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Sdt).HasMaxLength(50);

                entity.Property(e => e.Subject)
                    .HasMaxLength(50)
                    .HasColumnName("subject");
            });

            modelBuilder.Entity<DanhGium>(entity =>
            {
                entity.HasKey(e => e.MaRv);

                entity.Property(e => e.MaRv).HasColumnName("MaRV");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.Ndreview).HasColumnName("NDReview");

                entity.Property(e => e.NgayReview).HasColumnType("date");

                entity.HasOne(d => d.MaKhNavigation)
                    .WithMany(p => p.DanhGia)
                    .HasForeignKey(d => d.MaKh)
                    .HasConstraintName("FK_DanhGia_Customer");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.DanhGia)
                    .HasForeignKey(d => d.MaSp)
                    .HasConstraintName("FK_DanhGia_MonAn");
            });

            modelBuilder.Entity<GioHang>(entity =>
            {
                entity.HasKey(e => e.MaGh);

                entity.ToTable("GioHang");

                entity.Property(e => e.MaGh).HasColumnName("MaGH");

                entity.Property(e => e.GiaSp)
                    .HasColumnType("money")
                    .HasColumnName("GiaSP");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.TenSp)
                    .HasMaxLength(50)
                    .HasColumnName("TenSP");

                entity.Property(e => e.TongTien).HasColumnType("money");

                entity.HasOne(d => d.MaSpNavigation)
                    .WithMany(p => p.GioHangs)
                    .HasForeignKey(d => d.MaSp)
                    .HasConstraintName("FK_GioHang_MonAn");
            });

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.HasKey(e => e.MaHd);

                entity.ToTable("HoaDon");

                entity.Property(e => e.MaHd).HasColumnName("MaHD");

                entity.Property(e => e.GiaSp)
                    .HasColumnType("money")
                    .HasColumnName("GiaSP");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.NgayLap).HasColumnType("date");

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.TenKh)
                    .HasMaxLength(50)
                    .HasColumnName("TenKH");

                entity.Property(e => e.TenSp)
                    .HasMaxLength(50)
                    .HasColumnName("TenSP");

                entity.Property(e => e.TongTien).HasColumnType("money");

                entity.HasOne(d => d.MaAdNavigation)
                    .WithMany(p => p.HoaDons)
                    .HasForeignKey(d => d.MaAd)
                    .HasConstraintName("FK_HoaDon_NhanVien");
            });

            modelBuilder.Entity<MonAn>(entity =>
            {
                entity.HasKey(e => e.MaSp);

                entity.ToTable("MonAn");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");

                entity.Property(e => e.GiaSp)
                    .HasColumnType("money")
                    .HasColumnName("GiaSP");

                entity.Property(e => e.HinhAnh).HasMaxLength(50);

                entity.Property(e => e.TenSp)
                    .HasMaxLength(50)
                    .HasColumnName("TenSP");

                entity.HasOne(d => d.MaLoaiNavigation)
                    .WithMany(p => p.MonAns)
                    .HasForeignKey(d => d.MaLoai)
                    .HasConstraintName("FK_MonAn_Category");
            });

            modelBuilder.Entity<NhanVien>(entity =>
            {
                entity.HasKey(e => e.MaAd);

                entity.ToTable("NhanVien");

                entity.Property(e => e.Matkhau).HasMaxLength(50);

                entity.Property(e => e.TenAd).HasMaxLength(50);

                entity.Property(e => e.TenTk)
                    .HasMaxLength(50)
                    .HasColumnName("TenTK");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.MaKh)
                    .HasName("PK_Customer");

                entity.ToTable("User");

                entity.Property(e => e.MaKh).HasColumnName("MaKH");

                entity.Property(e => e.GioiTinh).HasMaxLength(50);

                entity.Property(e => e.Matkhau).HasMaxLength(50);

                entity.Property(e => e.Sdt).HasColumnName("SDT");

                entity.Property(e => e.TenKh)
                    .HasMaxLength(50)
                    .HasColumnName("TenKH");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
