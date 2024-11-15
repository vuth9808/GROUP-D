using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FengShuiKoi.Reponsitories.Entities;
using FengShuiKoi.Services.IServices;

namespace FengShuiKoi.WepApp_.Pages.Advertisement.Advertise
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
            //ViewData["MaCaKoi"] = new SelectList(_context.KoiFishes, "MaCaKoi", "GiongCa");
            //ViewData["MaGoi"] = new SelectList(_context.GoiDangTins, "MaGoi", "GiaTien");
            //ViewData["MaHoCa"] = new SelectList(_context.HoCas, "MaHoCa", "HinhDang");
            //ViewData["MaKhachHang"] = new SelectList(_context.KhachHangs, "MaKhachHang", "Email");
            return Page();
        }

        [BindProperty]
        public Avertise Avertise { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public IActionResult OnPost()
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
