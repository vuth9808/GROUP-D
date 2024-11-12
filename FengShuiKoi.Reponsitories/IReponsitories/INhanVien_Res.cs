using FengShuiKoi.Reponsitories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengShuiKoi.Reponsitories.IReponsitories
{
    internal interface INhanVien_Res
    {
        Task<List<NhanVien>> GetAllNhanVien();
        Boolean DelNhanvien(int Id);
        Boolean DelNhanvien(NhanVien account);
        Boolean AddNhanvien(NhanVien account);
        Boolean UpdNhanvien(NhanVien account);
        Task<NhanVien> GetNhanvienById(int Id);
    }
}
