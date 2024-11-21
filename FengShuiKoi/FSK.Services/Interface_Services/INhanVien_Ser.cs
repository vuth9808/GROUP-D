using FSK.Reponsitories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSK.Services.Interface_Services
{
    public interface INhanVien_Ser
    {
        Task<List<NhanVien>> NhanViens();
        Boolean DelNhanvien(string Id);
        Boolean DelNhanvien(NhanVien account);
        Boolean AddNhanvien(NhanVien account);
        Boolean UpdNhanvien(NhanVien account);
        Task<NhanVien> GetNhanvienById(string Id);
    }
}
