using FengShuiKoi.Reponsitories.Entities;
using FengShuiKoi.Reponsitories.Respon;
using FengShuiKoi.Reponsitories.Res;
using FengShuiKoi.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengShuiKoi.Services.Services
{
    public class NhanVien_Ser : INhanVien_Ser
    {
        private readonly NhanVien_Res _reponsitories;

        public NhanVien_Ser(NhanVien_Res reponsitories)
        {
            _reponsitories = reponsitories;
        }

        public bool AddNhanvien(NhanVien account)
        {
            return _reponsitories.AddNhanvien(account);
        }

        public bool DelNhanvien(int Id)
        {
            return _reponsitories.DelNhanvien(Id);
        }

        public bool DelNhanvien(NhanVien account)
        {
            return _reponsitories.DelNhanvien(account);
        }

        public async Task<List<NhanVien>> NhanViens()
        {
            return await _reponsitories.GetAllNhanVien();
        }

        public async Task<NhanVien> GetNhanvienById(int Id)
        {
            return await _reponsitories.GetNhanvienById(Id);
        }

        public bool UpdNhanvien(NhanVien account)
        {
            return _reponsitories.UpdNhanvien(account);
        }
    }
}
