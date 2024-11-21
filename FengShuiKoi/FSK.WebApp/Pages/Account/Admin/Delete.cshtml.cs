using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FSK.Reponsitories.Entities;
using FSK.Services;

namespace FSK.WebApp.Pages.Account.Admin
{
    public class DeleteModel : PageModel
    {
        private readonly IBaseServices _context;

        public DeleteModel(IBaseServices context)
        {
            _context = context;
        }

        [BindProperty]
        public NhanVien NhanVien { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(string? id)
        {
            
            if (id == null)
            {
               
                return NotFound();
            }

            
            //var nhanvien = await _context.NhanViens.FirstOrDefaultAsync(m => m.MaNhanVien == id);
            var nhanvien = await _context.NhanVienServices.GetNhanvienById(id);

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

            //var nhanvien = await _context.NhanVienServices.GetNhanvienById(id);
            //if (nhanvien != null)
            //{
            //    NhanVien = nhanvien;
            //    //_context.NhanViens.Remove(NhanVien);
            //    //await _context.SaveChangesAsync();
            //    _context.NhanVienServices.DelNhanvien(NhanVien);
            //}
            _context.NhanVienServices.DelNhanvien(id);

            return RedirectToPage("./Index");
        }
    }
}
