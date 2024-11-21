using FSK.Reponsitories.Interface_Respon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSK.Reponsitories
{
    public interface IBaseReponsitories
    {
        IAvertise_Res avertiseResponsitory { get; }
        IGoiDangTin_Res goiDangTinResponsitory { get; }
        IHoCa_Res hoCaResponsitory { get; }
        IKhachHang_Res KhachHangResponsitory { get; }
        IKoiFish_Res koiFishResponsitory { get; }
        INhanVien_Res nhanVienResponsitory { get; }

    }
}
