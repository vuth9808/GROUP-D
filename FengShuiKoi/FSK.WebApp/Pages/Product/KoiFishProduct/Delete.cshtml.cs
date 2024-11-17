using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FSK.Reponsitories.Entities;
using FSK.Services;

namespace FSK.WebApp.Pages.Product.KoiFishProduct
{
    public class DeleteModel : PageModel
    {
        private readonly IBaseServices _context;

        public DeleteModel(IBaseServices context)
        {
            _context = context;
        }

        [BindProperty]
        public KoiFish KoiFish { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var koifish = await _context.koiFishServices.GetKoiFishById((int)id);

            if (koifish == null)
            {
                return NotFound();
            }
            else
            {
                KoiFish = koifish;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var koifish = await _context.KoiFishes.FindAsync(id);
            //if (koifish != null)
            //{
            //    KoiFish = koifish;
            //    _context.KoiFishes.Remove(KoiFish);
            //    await _context.SaveChangesAsync();
            //}
            _context.koiFishServices.DelKoiFish((int)id);

            return RedirectToPage("./Index");
        }
    }
}
