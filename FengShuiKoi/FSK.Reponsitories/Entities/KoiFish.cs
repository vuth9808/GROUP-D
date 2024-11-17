using System;
using System.Collections.Generic;

namespace FSK.Reponsitories.Entities;

public partial class KoiFish
{
    public int MaCaKoi { get; set; }

    public int SoLuong { get; set; }

    public string GiongCa { get; set; } = null!;

    public string MoTa { get; set; } = null!;

    public string ThichHop { get; set; } = null!;

    public virtual ICollection<Avertise> Avertises { get; set; } = new List<Avertise>();
}
