using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FengShuiKoi.Reponsitories.Entities;
using FengShuiKoi.Services.IServices;

namespace FengShuiKoi.WepApp_.Pages.Advertisement.Advertise
{
    public class IndexModel : PageModel
    {
        private readonly IAvertise_Ser _context;

        public IndexModel(IAvertise_Ser context)
        {
            _context = context;
        }

        public IList<Avertise> Avertise { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Avertise = await _context.Avertises();
                //.Include(a => a.MaCaKoiNavigation)
                //.Include(a => a.MaGoiNavigation)
                //.Include(a => a.MaHoCaNavigation)
                //.Include(a => a.MaKhachHangNavigation).ToListAsync();
        }
    }
}
