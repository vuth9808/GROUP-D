using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FSK.Reponsitories.Entities;
using FSK.Services;

namespace FSK.WebApp.Pages.Account.Admin
{
    public class EditModel : PageModel
    {
        private readonly IBaseServices _context;

        public EditModel(IBaseServices context)
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

            var nhanvien =  await _context.NhanVienServices.GetNhanvienById(id);
            if (nhanvien == null)
            {
                return NotFound();
            }
            NhanVien = nhanvien;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.Attach(NhanVien).State = EntityState.Modified;
            _context.NhanVienServices.UpdNhanvien(NhanVien);

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!NhanVienExists(NhanVien.MaNhanVien))
            //    {
            //        return NotFound();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            return RedirectToPage("./Index");
        }

        private bool NhanVienExists(string id)
        {
            //return _context.NhanViens.Any(e => e.MaNhanVien == id);
            return NhanVien.Equals(_context.NhanVienServices.GetNhanvienById(id));

        }
    }
}
