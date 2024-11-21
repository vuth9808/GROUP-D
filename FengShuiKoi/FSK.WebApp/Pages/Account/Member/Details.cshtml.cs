using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FSK.Reponsitories.Entities;
using FSK.Services;

namespace FSK.WebApp.Pages.Account.Member
{
    public class DetailsModel : PageModel
    {
        private readonly IBaseServices _context;

        public DetailsModel(IBaseServices context)
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

            //var khachhang = await _context.KhachHangs.FirstOrDefaultAsync(m => m.MaKhachHang == id);
            var khachhang = await _context.khachHangServices.GetKhachHangById((int)id);
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
