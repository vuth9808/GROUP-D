using FSK.Reponsitories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSK.Services.Interface_Services
{
    public interface IKoiFish_Ser
    {
        Task<List<KoiFish>> KoiFishs();
        Boolean DelKoiFish(int Id);
        Boolean DelKoiFish(KoiFish product);
        Boolean AddKoiFish(KoiFish product);
        Boolean UpdKoiFish(KoiFish product);
        Task<KoiFish> GetKoiFishById(int Id);
    }
}
