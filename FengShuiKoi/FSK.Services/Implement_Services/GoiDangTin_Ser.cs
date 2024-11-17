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
    public class GoiDangTin_Ser : IGoiDangTin_Ser
    {
        private readonly IBaseReponsitories _baseRes;       

        public GoiDangTin_Ser(IBaseReponsitories baseRes)
        {
            _baseRes = baseRes;
        }


        public bool AddGoiDangTin(GoiDangTin Items)
        {
            return _baseRes.goiDangTinResponsitory.AddGoiDangTin(Items);
        }

        public bool DelGoiDangTin(int Id)
        {
           return _baseRes.goiDangTinResponsitory.DelGoiDangTin(Id);
        }

        public bool DelGoiDangTin(GoiDangTin Items)
        {
            return _baseRes.goiDangTinResponsitory.DelGoiDangTin(Items);
        }

        public Task<List<GoiDangTin>> GoiDangTins()
        {
            return _baseRes.goiDangTinResponsitory.GetAllGoiDangTin();
        }

        public Task<GoiDangTin> GetGoiDangTinById(int Id)
        {
            return _baseRes.goiDangTinResponsitory.GetGoiDangTinById(Id);
        }

        public bool UpdGoiDangTin(GoiDangTin Items)
        {
            return _baseRes.goiDangTinResponsitory.UpdGoiDangTin(Items);
        }
    }
}
