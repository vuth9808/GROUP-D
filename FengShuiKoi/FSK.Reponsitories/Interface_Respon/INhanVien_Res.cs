using FSK.Reponsitories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSK.Reponsitories.Interface_Respon
{
    public interface INhanVien_Res
    {
        Task<List<NhanVien>> GetAllNhanVien();
        Boolean DelNhanvien(string Id);
        Boolean DelNhanvien(NhanVien account);
        Boolean AddNhanvien(NhanVien account);
        Boolean UpdNhanvien(NhanVien account);
        Task<NhanVien> GetNhanvienById(string Id);
    }
}
