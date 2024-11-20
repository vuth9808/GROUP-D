using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FSK.Reponsitories.Entities;

public partial class KoiFish
{
    [Display(Name = "STT")]
    public int MaCaKoi { get; set; }
    [Display(Name = "Số Lượng")]
    public int SoLuong { get; set; }
    [Display(Name = "Gióng Cá")]
    public string GiongCa { get; set; } = null!;
    [Display(Name = "Mô tả cá")]
    public string MoTa { get; set; } = null!;
    [Display(Name = "Điều Kiện Thích Hợp")]
    public string ThichHop { get; set; } = null!;

    public virtual ICollection<Avertise> Avertises { get; set; } = new List<Avertise>();
}
