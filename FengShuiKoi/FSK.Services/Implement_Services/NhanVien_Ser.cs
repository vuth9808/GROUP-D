using FSK.Reponsitories;
using FSK.Reponsitories.Entities;
using FSK.Reponsitories.Implement_Respon;
using FSK.Reponsitories.Interface_Respon;
using FSK.Services.Interface_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSK.Services.Implement_Services
{
    public class NhanVien_Ser : INhanVien_Ser
    {
        private readonly IBaseReponsitories _baseRes;

        public NhanVien_Ser(IBaseReponsitories baseRes)
        {
            _baseRes = baseRes;
        }

        public bool AddNhanvien(NhanVien account)
        {
            return _baseRes.nhanVienResponsitory.AddNhanvien(account);
        }

        public bool DelNhanvien(string Id)
        {
            return _baseRes.nhanVienResponsitory.DelNhanvien(Id);
        }

        public bool DelNhanvien(NhanVien account)
        {
            return _baseRes.nhanVienResponsitory.DelNhanvien(account);
        }

        public Task<List<NhanVien>> NhanViens()
        {
            return _baseRes.nhanVienResponsitory.GetAllNhanVien();
        }

        public Task<NhanVien> GetNhanvienById(string Id)
        {
            return _baseRes.nhanVienResponsitory.GetNhanvienById(Id);
        }

        public bool UpdNhanvien(NhanVien account)
        {
            return _baseRes.nhanVienResponsitory.UpdNhanvien(account);
        }
    }
}
