using FSK.Reponsitories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSK.Reponsitories.Interface_Respon
{
    public interface IHoCa_Res
    {
        Task<List<HoCa>> GetAllHoCa();
        Boolean DelHoCa(int Id);
        Boolean DelHoCa(HoCa product);
        Boolean AddHoCa(HoCa product);
        Boolean UpdHoCa(HoCa product);
        Task<HoCa> GetHoCaById(int Id);

    }
}
