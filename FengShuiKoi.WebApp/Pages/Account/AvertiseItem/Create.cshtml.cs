using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FengShuiKoi.Reponsitories.Entities;
using FengShuiKoi.Services.IServices;

namespace FengShuiKoi.WebApp.Pages.Account.AvertiseItem
{
    public class CreateModel : PageModel
    {
        private readonly IAvertise_Ser _services;

        public CreateModel(IAvertise_Ser services)
        {
            _services = services; 
        }

        public IActionResult OnGet()
        {
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

            _services.AddAvertise(Avertise);

            return RedirectToPage("./Index");
        }
    }
}
