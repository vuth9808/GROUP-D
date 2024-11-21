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
    public class DetailsModel : PageModel
    {
        private readonly IBaseServices _context;

        public DetailsModel(IBaseServices context)
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
    }
}
