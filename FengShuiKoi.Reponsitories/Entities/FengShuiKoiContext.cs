using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FengShuiKoi.Reponsitories.Entities;

public partial class FengShuiKoiContext : DbContext
{
    public FengShuiKoiContext()
    {
    }

    public FengShuiKoiContext(DbContextOptions<FengShuiKoiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Avertise> Avertises { get; set; }

    public virtual DbSet<GoiDangTin> GoiDangTins { get; set; }

    public virtual DbSet<HoCa> HoCas { get; set; }

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<KoiFish> KoiFishes { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-I957D0S\\SQLSVV;Initial Catalog=FengShuiKoi;Integrated Security=True;Trust Server Certificate=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Avertise>(entity =>
        {
            entity.HasKey(e => e.MaQuangCao).HasName("PK__Avertise__2B7E825DC8AE6F1F");

            entity.ToTable("Avertise");

            entity.HasIndex(e => e.BanMenh, "UQ__Avertise__0388FF70508F33C4").IsUnique();

            entity.HasIndex(e => e.MoTa, "UQ__Avertise__08B451A5EA024B1F").IsUnique();

            entity.HasIndex(e => e.SanPhamTrangTri, "UQ__Avertise__945E6CCC0F9DD374").IsUnique();

            entity.Property(e => e.MaQuangCao)
                .ValueGeneratedNever()
                .HasColumnName("ma_quang_cao");
            entity.Property(e => e.BanMenh)
                .HasMaxLength(255)
                .HasColumnName("ban_menh");
            entity.Property(e => e.GiaTien).HasColumnName("gia_tien");
            entity.Property(e => e.MaCaKoi).HasColumnName("ma_ca_koi");
            entity.Property(e => e.MaGoi).HasColumnName("ma_goi");
            entity.Property(e => e.MaHoCa).HasColumnName("ma_ho_ca");
            entity.Property(e => e.MaKhachHang).HasColumnName("ma_khach_hang");
            entity.Property(e => e.MoTa)
                .HasMaxLength(255)
                .HasColumnName("mo_ta");
            entity.Property(e => e.NgayChinhSua)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_chinh_sua");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_tao");
            entity.Property(e => e.SanPhamTrangTri)
                .HasMaxLength(255)
                .HasColumnName("san_pham_trang_tri");

            entity.HasOne(d => d.MaCaKoiNavigation).WithMany(p => p.Avertises)
                .HasForeignKey(d => d.MaCaKoi)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Avertise__ma_ca___17036CC0");

            entity.HasOne(d => d.MaGoiNavigation).WithMany(p => p.Avertises)
                .HasForeignKey(d => d.MaGoi)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Avertise__ma_goi__1AD3FDA4");

            entity.HasOne(d => d.MaHoCaNavigation).WithMany(p => p.Avertises)
                .HasForeignKey(d => d.MaHoCa)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Avertise__ma_ho___17F790F9");

            entity.HasOne(d => d.MaKhachHangNavigation).WithMany(p => p.Avertises)
                .HasForeignKey(d => d.MaKhachHang)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Avertise__ma_kha__160F4887");
        });

        modelBuilder.Entity<GoiDangTin>(entity =>
        {
            entity.HasKey(e => e.MaGoi).HasName("PK__Goi_dang__072AC717DF56BE41");

            entity.ToTable("Goi_dang_tin");

            entity.HasIndex(e => e.TenGoi, "UQ__Goi_dang__54844CFA15822969").IsUnique();

            entity.Property(e => e.MaGoi)
                .ValueGeneratedNever()
                .HasColumnName("ma_goi");
            entity.Property(e => e.GiaTien)
                .HasMaxLength(255)
                .HasColumnName("gia_tien");
            entity.Property(e => e.TenGoi)
                .HasMaxLength(255)
                .HasColumnName("ten_goi");
        });

        modelBuilder.Entity<HoCa>(entity =>
        {
            entity.HasKey(e => e.MaHoCa).HasName("PK__Ho_ca__4C03B03851A69198");

            entity.ToTable("Ho_ca");

            entity.HasIndex(e => e.PhuongHuong, "UQ__Ho_ca__09A0AB6788A64CB4").IsUnique();

            entity.HasIndex(e => e.ViTri, "UQ__Ho_ca__7D4A867A44FD4B10").IsUnique();

            entity.HasIndex(e => e.KichThuoc, "UQ__Ho_ca__C706C33CE73C2429").IsUnique();

            entity.HasIndex(e => e.ThichHop, "UQ__Ho_ca__D264759EB2A33057").IsUnique();

            entity.HasIndex(e => e.HinhDang, "UQ__Ho_ca__DD158022C1656B69").IsUnique();

            entity.Property(e => e.MaHoCa)
                .ValueGeneratedNever()
                .HasColumnName("ma_ho_ca");
            entity.Property(e => e.HinhDang)
                .HasMaxLength(100)
                .HasColumnName("hinh_dang");
            entity.Property(e => e.KichThuoc)
                .HasMaxLength(100)
                .HasColumnName("kich_thuoc");
            entity.Property(e => e.PhuongHuong)
                .HasMaxLength(100)
                .HasColumnName("phuong_huong");
            entity.Property(e => e.ThichHop)
                .HasMaxLength(255)
                .HasColumnName("thich_hop");
            entity.Property(e => e.ViTri)
                .HasMaxLength(100)
                .HasColumnName("vi_tri");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKhachHang).HasName("PK__Khach_Ha__C9817AF64F2C0BF6");

            entity.ToTable("Khach_Hang");

            entity.HasIndex(e => e.Email, "UQ__Khach_Ha__AB6E616421DE4FAE").IsUnique();

            entity.HasIndex(e => e.MatKhau, "UQ__Khach_Ha__E1F09C0289895294").IsUnique();

            entity.Property(e => e.MaKhachHang).HasColumnName("ma_khach_hang");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.GioiTinh).HasColumnName("gioi_tinh");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("mat_khau");
            entity.Property(e => e.NgayChinhSua)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_chinh_sua");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_tao");
            entity.Property(e => e.NgayThangNamSinh).HasColumnName("ngay_thang_nam_sinh");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("so_dien_thoai");
            entity.Property(e => e.TenKhachHang)
                .HasMaxLength(255)
                .HasColumnName("ten_khach_hang");
            entity.Property(e => e.Tuoi).HasColumnName("tuoi");
        });

        modelBuilder.Entity<KoiFish>(entity =>
        {
            entity.HasKey(e => e.MaCaKoi).HasName("PK__KoiFish__27616D0C061004B1");

            entity.ToTable("KoiFish");

            entity.HasIndex(e => e.MoTa, "UQ__KoiFish__08B451A55E740167").IsUnique();

            entity.HasIndex(e => e.ThichHop, "UQ__KoiFish__D264759E8C9ED9F5").IsUnique();

            entity.HasIndex(e => e.GiongCa, "UQ__KoiFish__D37C3141B1595155").IsUnique();

            entity.Property(e => e.MaCaKoi)
                .ValueGeneratedNever()
                .HasColumnName("ma_ca_koi");
            entity.Property(e => e.GiongCa)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("giong_ca");
            entity.Property(e => e.MoTa)
                .HasMaxLength(255)
                .HasColumnName("mo_ta");
            entity.Property(e => e.SoLuong).HasColumnName("so_luong");
            entity.Property(e => e.ThichHop)
                .HasMaxLength(255)
                .HasColumnName("thich_hop");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__Nhan_Vie__6781B7B914A0C7DA");

            entity.ToTable("Nhan_Vien");

            entity.HasIndex(e => e.Email, "UQ__Nhan_Vie__AB6E6164BD750493").IsUnique();

            entity.Property(e => e.MaNhanVien)
                .HasMaxLength(10)
                .HasColumnName("ma_nhan_vien");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.GioiTinh).HasColumnName("gioi_tinh");
            entity.Property(e => e.HoTen)
                .HasMaxLength(255)
                .HasColumnName("ho_ten");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(255)
                .HasColumnName("mat_khau");
            entity.Property(e => e.NgayChinhSua)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_chinh_sua");
            entity.Property(e => e.NgayThangNamSinh).HasColumnName("ngay_thang_nam_sinh");
            entity.Property(e => e.NgayThem)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_them");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("so_dien_thoai");
            entity.Property(e => e.Tuoi).HasColumnName("tuoi");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
