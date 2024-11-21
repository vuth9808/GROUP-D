using FSK.Reponsitories;
using FSK.Services.Implement_Services;
using FSK.Services.Interface_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FSK.Services
{
    public class IplBaseServices : IBaseServices
    {
        private readonly IBaseReponsitories _baseRes;
        public IplBaseServices(IBaseReponsitories baseRes)
        {
            _baseRes = baseRes;
        }
        private IAvertise_Ser _avertiseServices;
        public IAvertise_Ser avertiseServices
        {
            get
            {
                return _avertiseServices ?? (_avertiseServices = new Avertise_Ser(_baseRes));
            }
        }

        private IGoiDangTin_Ser _goiDangTinServices;
        public IGoiDangTin_Ser goiDangTinServices
        {
            get
            {
                return _goiDangTinServices ?? (_goiDangTinServices = new GoiDangTin_Ser(_baseRes));
            }
        }

        private IHoCa_Ser _hoCaServices;
        public IHoCa_Ser hoCaServices
        {
            get
            {
                return _hoCaServices ?? (_hoCaServices = new HoCa_Ser(_baseRes));
            }
        }

        private IKhachHang_Ser _khachHangServices;
        public IKhachHang_Ser khachHangServices
        {
            get
            {
                return _khachHangServices ?? (_khachHangServices = new KhachHang_Ser(_baseRes));
            }
        }

        private IKoiFish_Ser _koiFishServices;
        public IKoiFish_Ser koiFishServices
        {
            get
            {
                return _koiFishServices ?? (_koiFishServices = new KoiFish_Ser(_baseRes));
            }
        }

        private INhanVien_Ser _nhanVienServices;
        public INhanVien_Ser NhanVienServices
        {
            get
            {
                return _nhanVienServices ?? (_nhanVienServices = new NhanVien_Ser(_baseRes));
            }
        }
    }
}
