using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FengShuiKoi.Reponsitories.Entities;
using FengShuiKoi.Services.IServices;

namespace FengShuiKoi.WebApp.Pages.Account.AvertiseItem
{
    public class DeleteModel : PageModel
    {
        private readonly IAvertise_Ser _service;

        public DeleteModel(IAvertise_Ser service)
        {
            _service = service;
        }

        [BindProperty]
        public Avertise Avertise { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            int Id = 0;
            if (id == null)
            {
                Id = 0;
                return NotFound();
            }

            Id = (int)id;
            var avertise = await _service.GetAvertiseById(Id);

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

            _service.DelAvertise((int)id);

            return RedirectToPage("./Index");
        }
    }
}
