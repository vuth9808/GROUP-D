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
    public class IndexModel : PageModel
    {
        private readonly IBaseServices _context;

        public IndexModel(IBaseServices context)
        {
            _context = context;
        }

        public IList<GoiDangTin> GoiDangTin { get;set; } = default!;

        public async Task OnGetAsync()
        {
            GoiDangTin = await _context.goiDangTinServices.GoiDangTins();
        }
    }
}
