using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FSK.Reponsitories.Entities;
using FSK.Services;

namespace FSK.WebApp.Pages.Avertisement.CacGoiDangTin
{
    public class DeleteModel : PageModel
    {
        private readonly IBaseServices _context;

        public DeleteModel(IBaseServices context)
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

            var goidangtin = await _context.goiDangTinServices.GetGoiDangTinById((int)id);

            if (goidangtin == null)
            {
                return NotFound();
            }
            else
            {
                GoiDangTin = goidangtin;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            _context.goiDangTinServices.DelGoiDangTin((int)id);
            //var goidangtin = await _context.GoiDangTins.FindAsync(id);
            //if (goidangtin != null)
            //{
            //    GoiDangTin = goidangtin;
            //    _context.GoiDangTins.Remove(GoiDangTin);
            //    await _context.SaveChangesAsync();
            //}

            return RedirectToPage("./Index");
        }
    }
}
