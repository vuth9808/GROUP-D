using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FengShuiKoi.Reponsitories.Entities;

namespace FengShuiKoi.Services.IServices
{
    public interface INhanVien_Ser
    {
        Task<List<NhanVien>> NhanViens();
        Boolean DelNhanvien(int Id);
        Boolean DelNhanvien(NhanVien account);
        Boolean AddNhanvien(NhanVien account);
        Boolean UpdNhanvien(NhanVien account);
        Task<NhanVien> GetNhanvienById(int Id);
    }
}
