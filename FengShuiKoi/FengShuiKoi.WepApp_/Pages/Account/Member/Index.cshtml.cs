﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FengShuiKoi.Reponsitories.Entities;

namespace FengShuiKoi.WepApp_.Pages.Account.NhanVienAccount
{
    public class IndexModel : PageModel
    {
        private readonly FengShuiKoi.Reponsitories.Entities.FengShuiKoiContext _context;

        public IndexModel(FengShuiKoi.Reponsitories.Entities.FengShuiKoiContext context)
        {
            _context = context;
        }

        public IList<NhanVien> NhanVien { get;set; } = default!;

        public async Task OnGetAsync()
        {
            NhanVien = await _context.NhanViens.ToListAsync();
        }
    }
}