using System;
using System.Collections.Generic;

namespace FSK.Reponsitories.Entities;

public partial class Avertise
{
    public int MaQuangCao { get; set; }

    public int? MaKhachHang { get; set; }

    public int? MaCaKoi { get; set; }

    public int? MaHoCa { get; set; }

    public string SanPhamTrangTri { get; set; } = null!;

    public string BanMenh { get; set; } = null!;

    public string MoTa { get; set; } = null!;

    public int GiaTien { get; set; }

    public DateTime? NgayTao { get; set; }

    public DateTime? NgayChinhSua { get; set; }

    public int? MaGoi { get; set; }

    public virtual KoiFish? MaCaKoiNavigation { get; set; }

    public virtual GoiDangTin? MaGoiNavigation { get; set; }

    public virtual HoCa? MaHoCaNavigation { get; set; }

    public virtual KhachHang? MaKhachHangNavigation { get; set; }
}
