using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FengShuiKoi.Reponsitories.Entities;
using FengShuiKoi.Services.IServices;

namespace FengShuiKoi.WebApp.Pages.Account.NhanVienAccount
{
    public class IndexModel : PageModel
    {
        private readonly INhanVien_Ser _NhanVien_Ser;

        public IndexModel(INhanVien_Ser NhanVien_Ser)
        {
            _NhanVien_Ser = NhanVien_Ser;
        }

        public IList<NhanVien> NhanVien { get;set; } = default!;

        public async Task OnGetAsync()
        {
            NhanVien = await _NhanVien_Ser.GetAllNhanVien();
        }
    }
}
