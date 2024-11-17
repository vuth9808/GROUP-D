using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FSK.Reponsitories.Entities;

namespace FSK.WebApp.Pages.Product.HoCaProduct
{
    public class CreateModel : PageModel
    {
        private readonly FSK.Reponsitories.Entities.FengShuiKoiContext _context;

        public CreateModel(FSK.Reponsitories.Entities.FengShuiKoiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public HoCa HoCa { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.HoCas.Add(HoCa);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
