using FSK.Reponsitories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSK.Services.Interface_Services
{
    public interface IGoiDangTin_Ser
    {
        Task<List<GoiDangTin>> GoiDangTins();
        Boolean DelGoiDangTin(int Id);
        Boolean DelGoiDangTin(GoiDangTin Items);
        Boolean AddGoiDangTin(GoiDangTin Items);
        Boolean UpdGoiDangTin(GoiDangTin Items);
        Task<GoiDangTin> GetGoiDangTinById(int Id);
    }
}
