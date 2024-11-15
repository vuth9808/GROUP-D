using System;
using System.Collections.Generic;

namespace FengShuiKoi.Reponsitories.Entities;

public partial class KhachHang
{
    public int MaKhachHang { get; set; }
    
    public string TenKhachHang { get; set; } = null!;

    public DateOnly NgayThangNamSinh { get; set; }

    public int Tuoi { get; set; }

    public string Email { get; set; } = null!;

    public string MatKhau { get; set; } = null!;

    public string SoDienThoai { get; set; } = null!;

    public bool GioiTinh { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayChinhSua { get; set; }

    public virtual ICollection<Avertise> Avertises { get; set; } = new List<Avertise>();
}
