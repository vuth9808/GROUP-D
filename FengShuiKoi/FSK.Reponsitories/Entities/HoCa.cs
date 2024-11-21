using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FSK.Reponsitories.Entities;

public partial class HoCa
{
    [Display(Name = "Mã Hồ Cá")]
    public int MaHoCa { get; set; }
    [Display(Name = "HÌnh dạng")]
    public string HinhDang { get; set; } = null!;
    [Display(Name = "Kích Thước")]
    public string KichThuoc { get; set; } = null!;
    [Display(Name = "Vị Trí")]
    public string ViTri { get; set; } = null!;
    [Display(Name = "Phương Hướng")]
    public string PhuongHuong { get; set; } = null!;
    [Display(Name = "Thích hợp")]
    public string ThichHop { get; set; } = null!;

    public virtual ICollection<Avertise> Avertises { get; set; } = new List<Avertise>();
}
