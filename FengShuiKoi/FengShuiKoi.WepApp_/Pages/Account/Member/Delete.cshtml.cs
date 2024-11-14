using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FengShuiKoi.Reponsitories.Entities;

namespace FengShuiKoi.WepApp_.Pages.Account.NhanVienAccount
{
    public class DeleteModel : PageModel
    {
        private readonly FengShuiKoi.Reponsitories.Entities.FengShuiKoiContext _context;

        public DeleteModel(FengShuiKoi.Reponsitories.Entities.FengShuiKoiContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nhanvien = await _context.NhanViens.FindAsync(id);
            if (nhanvien != null)
            {
                NhanVien = nhanvien;
                _context.NhanViens.Remove(NhanVien);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
