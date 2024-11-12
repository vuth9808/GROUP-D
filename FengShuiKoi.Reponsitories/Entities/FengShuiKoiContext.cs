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

    public virtual DbSet<KhachHang> KhachHangs { get; set; }

    public virtual DbSet<NhanVien> NhanViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-I957D0S\\SQLSVV;Initial Catalog=FengShuiKoi;Integrated Security=True;Trust Server Certificate=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Avertise>(entity =>
        {
            entity.HasKey(e => e.MaQuangCao).HasName("PK__Avertise__2B7E825DB42A5FC5");

            entity.ToTable("Avertise");

            entity.Property(e => e.MaQuangCao)
                .ValueGeneratedNever()
                .HasColumnName("ma_quang_cao");
            entity.Property(e => e.BanMenh)
                .HasMaxLength(255)
                .HasColumnName("ban_menh");
            entity.Property(e => e.GiaTien).HasColumnName("gia_tien");
            entity.Property(e => e.LoaiCa)
                .HasMaxLength(255)
                .HasColumnName("loai_ca");
            entity.Property(e => e.MaKhachHang).HasColumnName("ma_khach_hang");
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

            entity.HasOne(d => d.MaKhachHangNavigation).WithMany(p => p.Avertises)
                .HasForeignKey(d => d.MaKhachHang)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Avertise__ma_kha__5CD6CB2B");
        });

        modelBuilder.Entity<KhachHang>(entity =>
        {
            entity.HasKey(e => e.MaKhachHang).HasName("PK__Khach_Ha__C9817AF69C647B6F");

            entity.ToTable("Khach_Hang");

            entity.HasIndex(e => e.Email, "UQ__Khach_Ha__AB6E61649BFCE14F").IsUnique();

            entity.Property(e => e.MaKhachHang).HasColumnName("ma_khach_hang");
            entity.Property(e => e.ChinhSuaBoi)
                .HasMaxLength(255)
                .HasColumnName("chinh_sua_boi");
            entity.Property(e => e.DiaChi)
                .HasMaxLength(255)
                .HasColumnName("dia_chi");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.NgayChinhSua)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_chinh_sua");
            entity.Property(e => e.NgayTao)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("ngay_tao");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("so_dien_thoai");
            entity.Property(e => e.TaoBoi)
                .HasMaxLength(255)
                .HasColumnName("tao_boi");
            entity.Property(e => e.TenKhachHang)
                .HasMaxLength(255)
                .HasColumnName("ten_khach_hang");
        });

        modelBuilder.Entity<NhanVien>(entity =>
        {
            entity.HasKey(e => e.MaNhanVien).HasName("PK__Nhan_Vie__6781B7B9F7165FD0");

            entity.ToTable("Nhan_Vien");

            entity.HasIndex(e => e.Email, "UQ__Nhan_Vie__AB6E61644233FD3D").IsUnique();

            entity.Property(e => e.MaNhanVien)
                .HasMaxLength(10)
                .HasColumnName("ma_nhan_vien");
            entity.Property(e => e.CapNhatBoi)
                .HasMaxLength(255)
                .HasColumnName("cap_nhat_boi");
            entity.Property(e => e.CapNhatVaoNgay)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("cap_nhat_vao_ngay");
            entity.Property(e => e.DiaChia).HasColumnName("dia_chia");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.GioiTinh).HasColumnName("gioi_tinh");
            entity.Property(e => e.HoTen)
                .HasMaxLength(255)
                .HasColumnName("ho_ten");
            entity.Property(e => e.LanDangNhapCuoi)
                .HasColumnType("datetime")
                .HasColumnName("lan_dang_nhap_cuoi");
            entity.Property(e => e.MatKhau)
                .HasMaxLength(255)
                .HasColumnName("mat_khau");
            entity.Property(e => e.MoTa).HasColumnName("mo_ta");
            entity.Property(e => e.NgayThangNamSinh).HasColumnName("ngay_thang_nam_sinh");
            entity.Property(e => e.QueQuan)
                .HasMaxLength(255)
                .HasColumnName("que_quan");
            entity.Property(e => e.SoDienThoai)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("so_dien_thoai");
            entity.Property(e => e.ThemBoi)
                .HasMaxLength(255)
                .HasColumnName("them_boi");
            entity.Property(e => e.ThemVaoNgay)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("them_vao_ngay");
            entity.Property(e => e.TrangThai).HasColumnName("trang_thai");
            entity.Property(e => e.Tuoi).HasColumnName("tuoi");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
