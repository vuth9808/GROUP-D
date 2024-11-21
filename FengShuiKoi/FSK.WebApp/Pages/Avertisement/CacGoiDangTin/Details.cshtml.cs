using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FSK.Reponsitories.Entities;
using FSK.Services;

namespace FSK.WebApp.Pages.Avertisement.CacGoiDangTin
{
    public class DetailsModel : PageModel
    {
        private readonly IBaseServices _context;

        public DetailsModel(IBaseServices context)
        {
            _context = context;
        }

        public GoiDangTin GoiDangTin { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goidangtin = await _context.goiDangTinServices.GetGoiDangTinById((int)id);
            if (goidangtin == null)
            {
                return NotFound();
            }
            else
            {
                GoiDangTin = goidangtin;
            }
            return Page();
        }
    }
}
