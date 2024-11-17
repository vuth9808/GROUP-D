using FSK.Reponsitories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSK.Reponsitories.Interface_Respon
{
    public interface IKoiFish_Res
    {
        Task<List<KoiFish>> GetAllKoiFish();
        Boolean DelKoiFish(int Id);
        Boolean DelKoiFish(KoiFish product);
        Boolean AddKoiFish(KoiFish product);
        Boolean UpdKoiFish(KoiFish product);
        Task<KoiFish> GetKoiFishById(int Id);
    }
}
