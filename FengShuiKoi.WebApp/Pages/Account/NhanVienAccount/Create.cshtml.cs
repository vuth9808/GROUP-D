using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FengShuiKoi.Reponsitories.Entities;

namespace FengShuiKoi.WebApp.Pages.Account.NhanVienAccount
{
    public class CreateModel : PageModel
    {
        private readonly FengShuiKoi.Reponsitories.Entities.FengShuiKoiContext _context;

        public CreateModel(FengShuiKoi.Reponsitories.Entities.FengShuiKoiContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public NhanVien NhanVien { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.NhanViens.Add(NhanVien);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
