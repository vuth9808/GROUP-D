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
    public class IndexModel : PageModel
    {
        private readonly IAvertise_Ser _Avertise_Ser;

        public IndexModel(IAvertise_Ser Avertise_Ser)
        {
            _Avertise_Ser = Avertise_Ser;
        }

        public IList<Avertise> Avertise { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Avertise = await _Avertise_Ser.Avertises();
        }
    }
}
