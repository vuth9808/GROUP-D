﻿using System;
using System.Collections.Generic;

namespace FengShuiKoi.Reponsitories.Entities;

public partial class HoCa
{
    public int MaHoCa { get; set; }

    public string HinhDang { get; set; } = null!;

    public string KichThuoc { get; set; } = null!;

    public string ViTri { get; set; } = null!;

    public string PhuongHuong { get; set; } = null!;

    public string ThichHop { get; set; } = null!;
}