using FengShuiKoi.Reponsitories.Entities;
using FengShuiKoi.Reponsitories.Respon;
using FengShuiKoi.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengShuiKoi.Services.Services
{
    public class Avertise_Ser : IAvertise_Ser
    {
        private readonly Avertise_Res _reponsitories;

        public Avertise_Ser(Avertise_Res reponsitories)
        {
            _reponsitories = reponsitories;
        }

        public bool AddAvertise(Avertise Items)
        {
            return _reponsitories.AddAvertise(Items);
        }

        public bool DelAvertise(int Id)
        {
            return _reponsitories.DelAvertise(Id);
        }

        public bool DelAvertise(Avertise Items)
        {
            return _reponsitories.DelAvertise(Items);
        }

        public async Task<List<Avertise>> Avertises()
        {
            return await _reponsitories.GetAllAvertise();
        }

        public async Task<Avertise> GetAvertiseById(int Id)
        {
            return await _reponsitories.GetAvertiseById(Id);
        }

        public bool UpdAvertise(Avertise Items)
        {
            return _reponsitories.UpdAvertise(Items);
        }
    }
}
