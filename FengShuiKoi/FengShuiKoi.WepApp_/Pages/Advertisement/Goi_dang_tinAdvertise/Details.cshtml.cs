using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FengShuiKoi.Reponsitories.Entities;

namespace FengShuiKoi.WepApp_.Pages.Advertisement.Goi_dang_tinAdvertise
{
    public class DetailsModel : PageModel
    {
        private readonly FengShuiKoi.Reponsitories.Entities.FengShuiKoiContext _context;

        public DetailsModel(FengShuiKoi.Reponsitories.Entities.FengShuiKoiContext context)
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

            var goidangtin = await _context.GoiDangTins.FirstOrDefaultAsync(m => m.MaGoi == id);
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
