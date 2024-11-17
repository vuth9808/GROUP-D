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
    public class HoCa_Ser : IHoCa_Ser
    {
        private readonly IBaseReponsitories _baseRes;

        public HoCa_Ser(IBaseReponsitories baseRes) { _baseRes = baseRes; }


        public bool AddHoCa(HoCa product)
        {
            return _baseRes.hoCaResponsitory.AddHoCa(product);
        }

        public bool DelHoCa(int Id)
        {
            return _baseRes.hoCaResponsitory.DelHoCa(Id);
        }

        public bool DelHoCa(HoCa product)
        {
            return _baseRes.hoCaResponsitory.DelHoCa(product);
        }

        public Task<List<HoCa>> HoCas()
        {
            return _baseRes.hoCaResponsitory.GetAllHoCa();            
        }

        public Task<HoCa> GetHoCaById(int Id)
        {
            return _baseRes.hoCaResponsitory.GetHoCaById(Id);
        }

        public bool UpdHoCa(HoCa product)
        {
            return _baseRes.hoCaResponsitory.UpdHoCa(product);
        }
    }
}
