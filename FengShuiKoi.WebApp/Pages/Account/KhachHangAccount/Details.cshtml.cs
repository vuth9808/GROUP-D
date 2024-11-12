using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FengShuiKoi.Reponsitories.Entities;

namespace FengShuiKoi.WebApp.Pages.Account.KhachHangAccount
{
    public class DetailsModel : PageModel
    {
        private readonly FengShuiKoi.Reponsitories.Entities.FengShuiKoiContext _context;

        public DetailsModel(FengShuiKoi.Reponsitories.Entities.FengShuiKoiContext context)
        {
            _context = context;
        }

        public KhachHang KhachHang { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachhang = await _context.KhachHangs.FirstOrDefaultAsync(m => m.MaKhachHang == id);
            if (khachhang == null)
            {
                return NotFound();
            }
            else
            {
                KhachHang = khachhang;
            }
            return Page();
        }
    }
}
