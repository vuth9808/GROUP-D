using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FSK.Reponsitories.Entities;

namespace FSK.WebApp.Pages.Avertisement.QuangCao
{
    public class DeleteModel : PageModel
    {
        private readonly FSK.Reponsitories.Entities.FengShuiKoiContext _context;

        public DeleteModel(FSK.Reponsitories.Entities.FengShuiKoiContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Avertise Avertise { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avertise = await _context.Avertises.FirstOrDefaultAsync(m => m.MaQuangCao == id);

            if (avertise == null)
            {
                return NotFound();
            }
            else
            {
                Avertise = avertise;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var avertise = await _context.Avertises.FindAsync(id);
            if (avertise != null)
            {
                Avertise = avertise;
                _context.Avertises.Remove(Avertise);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
