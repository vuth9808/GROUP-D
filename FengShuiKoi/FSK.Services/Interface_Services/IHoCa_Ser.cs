using FSK.Reponsitories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSK.Services.Interface_Services
{
    public interface IHoCa_Ser
    {
        Task<List<HoCa>> HoCas();
        Boolean DelHoCa(int Id);
        Boolean DelHoCa(HoCa product);
        Boolean AddHoCa(HoCa product);
        Boolean UpdHoCa(HoCa product);
        Task<HoCa> GetHoCaById(int Id);
    }
}
