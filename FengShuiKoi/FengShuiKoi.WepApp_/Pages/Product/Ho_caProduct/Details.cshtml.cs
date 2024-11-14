using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FengShuiKoi.Reponsitories.Entities;

namespace FengShuiKoi.WepApp_.Pages.Product.Ho_caProduct
{
    public class DetailsModel : PageModel
    {
        private readonly FengShuiKoi.Reponsitories.Entities.FengShuiKoiContext _context;

        public DetailsModel(FengShuiKoi.Reponsitories.Entities.FengShuiKoiContext context)
        {
            _context = context;
        }

        public HoCa HoCa { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hoca = await _context.HoCas.FirstOrDefaultAsync(m => m.MaHoCa == id);
            if (hoca == null)
            {
                return NotFound();
            }
            else
            {
                HoCa = hoca;
            }
            return Page();
        }
    }
}
