using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FengShuiKoi.Reponsitories.Entities;

namespace FengShuiKoi.WebApp.Pages.Account.NhanVienAccount
{
    public class DetailsModel : PageModel
    {
        private readonly FengShuiKoi.Reponsitories.Entities.FengShuiKoiContext _context;

        public DetailsModel(FengShuiKoi.Reponsitories.Entities.FengShuiKoiContext context)
        {
            _context = context;
        }

        public NhanVien NhanVien { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanvien = await _context.NhanViens.FirstOrDefaultAsync(m => m.MaNhanVien == id);
            if (nhanvien == null)
            {
                return NotFound();
            }
            else
            {
                NhanVien = nhanvien;
            }
            return Page();
        }
    }
}
