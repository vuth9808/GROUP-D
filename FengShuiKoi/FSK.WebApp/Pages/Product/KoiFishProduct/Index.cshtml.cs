using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FSK.Reponsitories.Entities;
using FSK.Services;

namespace FSK.WebApp.Pages.Product.KoiFishProduct
{
    public class IndexModel : PageModel
    {
        private readonly IBaseServices _context;

        public IndexModel(IBaseServices context)
        {
            _context = context;
        }

        public IList<KoiFish> KoiFish { get;set; } = default!;

        public async Task OnGetAsync()
        {
            KoiFish = await _context.koiFishServices.KoiFishs();
        }
    }
}
