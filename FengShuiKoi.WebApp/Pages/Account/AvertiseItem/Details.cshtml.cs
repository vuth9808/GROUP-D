using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FengShuiKoi.Reponsitories.Entities;
using FengShuiKoi.Services.IServices;
using NuGet.Versioning;

namespace FengShuiKoi.WebApp.Pages.Account.AvertiseItem
{
    public class DetailsModel : PageModel
    {
        private readonly IAvertise_Ser _context;

        public DetailsModel(IAvertise_Ser context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
