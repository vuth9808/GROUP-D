using FengShuiKoi.Reponsitories.Entities;
using FengShuiKoi.Reponsitories.Res;
using FengShuiKoi.Reponsitories.Respon;
using FengShuiKoi.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengShuiKoi.Services.Services
{
    public class KhachHang_Ser : IKhachHang_Ser
    {
        private readonly KhachHang_Res _reponsitories;

        public KhachHang_Ser(KhachHang_Res reponsitories)
        {
            _reponsitories = reponsitories;
        }

        public bool AddKhachHang(KhachHang account)
        {
            return _reponsitories.AddKhachHang(account);
        }

        public bool DelKhachHang(int Id)
        {
            return _reponsitories.DelKhachHang(Id);
        }

        public bool DelKhachHang(KhachHang account)
        {
            return _reponsitories.DelKhachHang(account);
        }

        public async Task<List<KhachHang>> KhachHangs()
        {
            return await _reponsitories.GetAllKhachHang();
        }

        public async Task<KhachHang> GetKhachHangById(int Id)
        {
            return await _reponsitories.GetKhachHangById(Id);
        }

        public bool UpdKhachHang(KhachHang account)
        {
            return _reponsitories.UpdKhachHang(account);
        }
    }
}
