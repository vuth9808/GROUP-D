using System;
using System.Collections.Generic;

namespace FSK.Reponsitories.Entities;

public partial class NhanVien
{
    public string MaNhanVien { get; set; } = null!;

    public string HoTen { get; set; } = null!;

    public DateOnly NgayThangNamSinh { get; set; }

    public int Tuoi { get; set; }

    public bool GioiTinh { get; set; }

    public string SoDienThoai { get; set; } = null!;

    public string? Email { get; set; }

    public string MatKhau { get; set; } = null!;

    public DateTime? NgayThem { get; set; }

    public DateTime? NgayChinhSua { get; set; }
}
