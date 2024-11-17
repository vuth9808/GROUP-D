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
    partial class KoiFish_Ser : IKoiFish_Ser
    {
        private readonly IBaseReponsitories _baseRes;
        public KoiFish_Ser(IBaseReponsitories baseRes)
        {
            _baseRes = baseRes;
        }

        public bool AddKoiFish(KoiFish product)
        {
            return _baseRes.koiFishResponsitory.AddKoiFish(product);
        }

        public bool DelKoiFish(int Id)
        {
            return _baseRes.koiFishResponsitory.DelKoiFish(Id);
        }

        public bool DelKoiFish(KoiFish product)
        {
            return _baseRes.koiFishResponsitory.DelKoiFish(product);
        }

        public Task<List<KoiFish>> KoiFishs()
        {
            return _baseRes.koiFishResponsitory.GetAllKoiFish();
        }

        public Task<KoiFish> GetKoiFishById(int Id)
        {
            return _baseRes.koiFishResponsitory.GetKoiFishById(Id);
        }

        public bool UpdKoiFish(KoiFish product)
        {
            return _baseRes.koiFishResponsitory.UpdKoiFish(product);
        }
    }
}
