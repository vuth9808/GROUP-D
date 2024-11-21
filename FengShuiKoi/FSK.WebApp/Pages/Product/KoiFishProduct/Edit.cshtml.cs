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

namespace FSK.WebApp.Pages.Product.KoiFishProduct
{
    public class EditModel : PageModel
    {
        private readonly IBaseServices _context;

        public EditModel(IBaseServices context)
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

            var koifish =  await _context.koiFishServices.GetKoiFishById((int)id);
            if (koifish == null)
            {
                return NotFound();
            }
            KoiFish = koifish;
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

            //_context.Attach(KoiFish).State = EntityState.Modified;
            _context.koiFishServices.UpdKoiFish(KoiFish);

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!KoiFishExists(KoiFish.MaCaKoi))
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

        private bool KoiFishExists(int id)
        {
            return KoiFish.Equals(_context.koiFishServices.GetKoiFishById(id));
        }
    }
}
