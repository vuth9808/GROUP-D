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
    public class DeleteModel : PageModel
    {
        private readonly IBaseServices _context;

        public DeleteModel(IBaseServices context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var hoca = await _context.hoCaServices.GetHoCaById((int)id);
            //if (hoca != null)
            //{
            //    HoCa = hoca;
            //    _context.hoCaServices.DelHoCa(HoCa);
            //}
            _context.hoCaServices.DelHoCa((int)id);

            return RedirectToPage("./Index");
        }
    }
}
