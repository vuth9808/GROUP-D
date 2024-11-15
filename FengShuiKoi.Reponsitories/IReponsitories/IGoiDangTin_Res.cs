using FengShuiKoi.Reponsitories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengShuiKoi.Reponsitories.IReponsitories
{
    public interface IGoiDangTin_Res
    {
        Task<List<GoiDangTin>> GetAllGoiDangTin();
        Boolean DelGoiDangTin(int Id);
        Boolean DelGoiDangTin(GoiDangTin Items);
        Boolean AddGoiDangTin(GoiDangTin Items);
        Boolean UpdGoiDangTin(GoiDangTin Items);
        Task<GoiDangTin> GetGoiDangTinById(int Id);
    }
}
