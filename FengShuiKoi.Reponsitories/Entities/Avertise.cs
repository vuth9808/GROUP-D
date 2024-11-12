using System;
using System.Collections.Generic;

namespace FengShuiKoi.Reponsitories.Entities;

public partial class Avertise
{
    public int? MaKhachHang { get; set; }

    public int MaQuangCao { get; set; }

    public string? LoaiCa { get; set; }

    public string? SanPhamTrangTri { get; set; }

    public string? BanMenh { get; set; }

    public int? GiaTien { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayChinhSua { get; set; }

    public virtual KhachHang? MaKhachHangNavigation { get; set; }
}
