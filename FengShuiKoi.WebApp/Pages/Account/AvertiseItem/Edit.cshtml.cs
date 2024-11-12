using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FengShuiKoi.Reponsitories.Entities;
using FengShuiKoi.Services.IServices;

namespace FengShuiKoi.WebApp.Pages.Account.AvertiseItem
{
    public class EditModel : PageModel
    {
        private readonly IAvertise_Ser _context;

        public EditModel(IAvertise_Ser context)
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

            var avertise = await _context.GetAvertiseById((int)id);
            if (avertise == null)
            {
                return NotFound();
            }
            else
            {
                Avertise = avertise;
            }
           //ViewData["MaKhachHang"] = new SelectList(_context.KhachHangs, "MaKhachHang", "MaKhachHang");
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

            _context.UpdAvertise(Avertise);

            return RedirectToPage("./Index");
        }

        private bool AvertiseExists(int id)
        {
            return _context.GetAvertiseById(id) != null;
        }
    }
}
