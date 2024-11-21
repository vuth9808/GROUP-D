using FSK.Reponsitories.Interface_Respon;
using FSK.Services.Interface_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSK.Services
{
    public interface IBaseServices
    {
        IAvertise_Ser avertiseServices {  get; }
        IGoiDangTin_Ser goiDangTinServices { get; }
        IHoCa_Ser hoCaServices { get; }
        IKhachHang_Ser khachHangServices { get; }
        IKoiFish_Ser koiFishServices { get; }
        INhanVien_Ser NhanVienServices { get; }
    }
}
