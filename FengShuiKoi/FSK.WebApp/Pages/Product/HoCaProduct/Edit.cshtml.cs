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

namespace FSK.WebApp.Pages.Product.HoCaProduct
{
    public class EditModel : PageModel
    {
        private readonly IBaseServices _context;

        public EditModel(IBaseServices context)
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
            HoCa = hoca;
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

            //_context.Attach(HoCa).State = EntityState.Modified;
            _context.hoCaServices.UpdHoCa(HoCa);

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!HoCaExists(HoCa.MaHoCa))
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

        private bool HoCaExists(int id)
        {
            return HoCa.Equals(_context.hoCaServices.GetHoCaById(id));
        }
    }
}
