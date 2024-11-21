using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FSK.Reponsitories.Entities;

namespace FSK.WebApp.Pages.Avertisement.QuangCao
{
    public class EditModel : PageModel
    {
        private readonly FSK.Reponsitories.Entities.FengShuiKoiContext _context;

        public EditModel(FSK.Reponsitories.Entities.FengShuiKoiContext context)
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

            var avertise =  await _context.Avertises.FirstOrDefaultAsync(m => m.MaQuangCao == id);
            if (avertise == null)
            {
                return NotFound();
            }
            Avertise = avertise;
           ViewData["MaCaKoi"] = new SelectList(_context.KoiFishes, "MaCaKoi", "GiongCa");
           ViewData["MaGoi"] = new SelectList(_context.GoiDangTins, "MaGoi", "GiaTien");
           ViewData["MaHoCa"] = new SelectList(_context.HoCas, "MaHoCa", "HinhDang");
           ViewData["MaKhachHang"] = new SelectList(_context.KhachHangs, "MaKhachHang", "Email");
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

            _context.Attach(Avertise).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AvertiseExists(Avertise.MaQuangCao))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AvertiseExists(int id)
        {
            return _context.Avertises.Any(e => e.MaQuangCao == id);
        }
    }
}
