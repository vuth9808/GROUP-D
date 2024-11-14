using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FengShuiKoi.Reponsitories.Entities;

namespace FengShuiKoi.WepApp_.Pages.Advertisement.Advertise
{
    public class IndexModel : PageModel
    {
        private readonly FengShuiKoi.Reponsitories.Entities.FengShuiKoiContext _context;

        public IndexModel(FengShuiKoi.Reponsitories.Entities.FengShuiKoiContext context)
        {
            _context = context;
        }

        public IList<Avertise> Avertise { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Avertise = await _context.Avertises
                .Include(a => a.MaCaKoiNavigation)
                .Include(a => a.MaGoiNavigation)
                .Include(a => a.MaHoCaNavigation)
                .Include(a => a.MaKhachHangNavigation).ToListAsync();
        }
    }
}
