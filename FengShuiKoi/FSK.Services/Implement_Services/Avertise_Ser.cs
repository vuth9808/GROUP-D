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
    public class Avertise_Ser : IAvertise_Ser
    {
        private readonly IBaseReponsitories _baseRes;
        

        public Avertise_Ser(IBaseReponsitories baseRes)
        {
            _baseRes = baseRes;
        }

        

        public bool AddAvertise(Avertise Items)
        {
            return _baseRes.avertiseResponsitory.AddAvertise(Items);
        }

        public bool DelAvertise(int Id)
        {
            return _baseRes.avertiseResponsitory.DelAvertise(Id);
        }

        public bool DelAvertise(Avertise Items)
        {
            return _baseRes.avertiseResponsitory.DelAvertise(Items);
        }

        public Task<List<Avertise>> Avertises()
        {
            return _baseRes.avertiseResponsitory.GetAllAvertise();
        }

        public Task<Avertise> GetAvertiseById(int Id)
        {
            return _baseRes.avertiseResponsitory.GetAvertiseById(Id);
        }

        public bool UpdAvertise(Avertise Items)
        {
            return _baseRes.avertiseResponsitory.UpdAvertise(Items);
        }
    }
}
