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

namespace FSK.WebApp.Pages.Account.Member
{
    public class EditModel : PageModel
    {
        private readonly IBaseServices _context;

        public EditModel(IBaseServices context)
        {
            _context = context;
        }

        [BindProperty]
        public KhachHang KhachHang { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var khachhang =  await _context.khachHangServices.GetKhachHangById((int)id);
            if (khachhang == null)
            {
                return NotFound();
            }
            KhachHang = khachhang;
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

            //_context.Attach(KhachHang).State = EntityState.Modified;
            _context.khachHangServices.UpdKhachHang(KhachHang);
            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!KhachHangExists(KhachHang.MaKhachHang))
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

        private bool KhachHangExists(int id)
        {
            //return _context.KhachHangs.Any(e => e.MaKhachHang == id);
            return KhachHang.Equals(_context.khachHangServices.GetKhachHangById((int)id));
        }
    }
}
