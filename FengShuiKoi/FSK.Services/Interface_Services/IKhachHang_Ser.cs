using FSK.Reponsitories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSK.Services.Interface_Services
{
    public interface IKhachHang_Ser
    {
        Task<List<KhachHang>> KhachHangs();
        Boolean DelKhachHang(int Id);
        Boolean DelKhachHang(KhachHang account);
        Boolean AddKhachHang(KhachHang account);
        Boolean UpdKhachHang(KhachHang account);
        Task<KhachHang> GetKhachHangById(int Id);
    }
}
