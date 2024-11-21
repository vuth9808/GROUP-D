using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FSK.Reponsitories.Entities;
using FSK.Services;

namespace FSK.WebApp.Pages.Product.HoCaProduct
{
    public class DetailsModel : PageModel
    {
        private readonly IBaseServices _context;

        public DetailsModel(IBaseServices context)
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

            var hoca = await _context.hoCaServices.GetHoCaById((int)id);
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
