using FSK.Reponsitories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSK.Reponsitories.Interface_Respon
{
    public interface IKhachHang_Res
    {
        Task<List<KhachHang>> GetAllKhachHang();
        Boolean DelKhachHang(int Id);
        Boolean DelKhachHang(KhachHang account);
        Boolean AddKhachHang(KhachHang account);
        Boolean UpdKhachHang(KhachHang account);
        Task<KhachHang> GetKhachHangById(int Id);
    }
}
