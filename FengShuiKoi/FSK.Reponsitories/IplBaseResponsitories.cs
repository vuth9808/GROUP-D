using FSK.Reponsitories.Entities;
using FSK.Reponsitories.Implement_Respon;
using FSK.Reponsitories.Interface_Respon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSK.Reponsitories
{
    public class IplBaseResponsitories : IBaseReponsitories
    {
        private readonly FengShuiKoiContext _context;
        public IplBaseResponsitories(FengShuiKoiContext context)
        {
            _context = context;
        }

        private IAvertise_Res _avertiseResponsitory;
        public IAvertise_Res avertiseResponsitory
        {
            get
            {
                return _avertiseResponsitory ?? (_avertiseResponsitory = new Avertise_Res(_context));
            }
        }

        private IGoiDangTin_Res _goiDangTinResponsitory;
        public IGoiDangTin_Res goiDangTinResponsitory
        {
            get
            {
                return _goiDangTinResponsitory ?? (_goiDangTinResponsitory = new GoiDangTin_Res(_context));
            }
        }

        private IHoCa_Res _hoCaResponsitory;
        public IHoCa_Res hoCaResponsitory
        {
            get
            {
                return _hoCaResponsitory ?? (_hoCaResponsitory= new HoCa_Res(_context));
            }
        }

        private IKhachHang_Res _khachHangResponsitory;
        public IKhachHang_Res KhachHangResponsitory
        {
            get
            {
                return _khachHangResponsitory ?? (_khachHangResponsitory = new KhachHang_Res(_context));
            }
        }

        private IKoiFish_Res _koiFishResponsitory;
        public IKoiFish_Res koiFishResponsitory
        {
            get
            {
                return _koiFishResponsitory ?? (_koiFishResponsitory = new KoiFish_Res(_context));
            }
        }

        private INhanVien_Res _nhanVienResponsitory;
        public INhanVien_Res nhanVienResponsitory
        {
            get
            {
                return _nhanVienResponsitory ?? (_nhanVienResponsitory = new NhanVien_Res(_context));
            }
        }
    }
}
