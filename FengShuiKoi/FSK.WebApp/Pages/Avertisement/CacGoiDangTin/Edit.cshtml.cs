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

namespace FSK.WebApp.Pages.Avertisement.CacGoiDangTin
{
    public class EditModel : PageModel
    {
        private readonly IBaseServices _context;

        public EditModel(IBaseServices context)
        {
            _context = context;
        }

        [BindProperty]
        public GoiDangTin GoiDangTin { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var goidangtin =  await _context.goiDangTinServices.GetGoiDangTinById((int)id);
            if (goidangtin == null)
            {
                return NotFound();
            }
            GoiDangTin = goidangtin;
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

            _context.goiDangTinServices.UpdGoiDangTin(GoiDangTin);
            //_context.Attach(GoiDangTin).State = EntityState.Modified;

            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateConcurrencyException)
            //{
            //    if (!GoiDangTinExists(GoiDangTin.MaGoi))
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

        private bool GoiDangTinExists(int id)
        {
            return GoiDangTin.Equals(_context.goiDangTinServices.GetGoiDangTinById(id));
        }
    }
}
