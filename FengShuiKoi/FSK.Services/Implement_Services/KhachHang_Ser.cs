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
    public class KhachHang_Ser : IKhachHang_Ser
    {
        private readonly IBaseReponsitories _baseRes;
       

        public KhachHang_Ser(IBaseReponsitories baseRes)
        {
            _baseRes = baseRes;
        }

        

        public bool AddKhachHang(KhachHang account)
        {
            return _baseRes.KhachHangResponsitory.AddKhachHang(account);
        }

        public bool DelKhachHang(int Id)
        {
            return _baseRes.KhachHangResponsitory.DelKhachHang(Id);
        }

        public bool DelKhachHang(KhachHang account)
        {
            return _baseRes.KhachHangResponsitory.DelKhachHang(account);
        }

        public async Task<List<KhachHang>> KhachHangs()
        {
            return await _baseRes.KhachHangResponsitory.GetAllKhachHang();
        }

        public async Task<KhachHang> GetKhachHangById(int Id)
        {
            return await _baseRes.KhachHangResponsitory.GetKhachHangById(Id);
        }

        public bool UpdKhachHang(KhachHang account)
        {
            return _baseRes.KhachHangResponsitory.UpdKhachHang(account);
        } 
    }
}
