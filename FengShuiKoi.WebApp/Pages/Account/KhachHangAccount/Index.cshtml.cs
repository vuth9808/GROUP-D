using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FengShuiKoi.Reponsitories.Entities;
using FengShuiKoi.Services.IServices;

namespace FengShuiKoi.WebApp.Pages.Account.KhachHangAccount
{
    public class IndexModel : PageModel
    {
        private readonly IKhachHang_Ser _KhachHang_Ser;

        public IndexModel(IKhachHang_Ser KhachHang_Ser)
        {
            _KhachHang_Ser = KhachHang_Ser;
        }

        public IList<KhachHang> KhachHang { get;set; } = default!;

        public async Task OnGetAsync()
        {
            KhachHang = await _KhachHang_Ser.GetAllKhachHang();
        }
    }
}
