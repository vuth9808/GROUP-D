using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FengShuiKoi.Reponsitories.Entities;

namespace FengShuiKoi.WepApp_.Pages.Advertisement.Advertise
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
        ViewData["MaCaKoi"] = new SelectList(_context.KoiFishes, "MaCaKoi", "GiongCa");
        ViewData["MaGoi"] = new SelectList(_context.GoiDangTins, "MaGoi", "GiaTien");
        ViewData["MaHoCa"] = new SelectList(_context.HoCas, "MaHoCa", "HinhDang");
        ViewData["MaKhachHang"] = new SelectList(_context.KhachHangs, "MaKhachHang", "Email");
            return Page();
        }

        [BindProperty]
        public Avertise Avertise { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Avertises.Add(Avertise);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
