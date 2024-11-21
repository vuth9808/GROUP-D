using System;
using System.Collections.Generic;

namespace FSK.Reponsitories.Entities;

public partial class GoiDangTin
{
    public int MaGoi { get; set; }

    public string TenGoi { get; set; } = null!;

    public string GiaTien { get; set; } = null!;

    public virtual ICollection<Avertise> Avertises { get; set; } = new List<Avertise>();
}
