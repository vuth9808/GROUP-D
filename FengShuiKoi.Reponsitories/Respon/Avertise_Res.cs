using FengShuiKoi.Reponsitories.Entities;
using FengShuiKoi.Reponsitories.IReponsitories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengShuiKoi.Reponsitories.Respon
{
    public class Avertise_Res : IAvertise_Res
    {
        private readonly FengShuiKoiContext _dbContext;

        public Avertise_Res(FengShuiKoiContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public bool AddAvertise(Avertise Items)
        {
            try
            {
                _dbContext.Avertises.Add(Items);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DelAvertise(int Id)
        {
            try
            {
                var objDel = _dbContext.Avertises.Where(p => p.MaQuangCao.Equals(Id)).FirstOrDefault();
                if (objDel != null)
                {
                    _dbContext.Avertises.Remove(objDel);
                    _dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());

            }
        }

        public bool DelAvertise(Avertise Items)
        {
            try
            {
                _dbContext.Avertises.Remove(Items);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
                return false;
            }
        }

        public async Task<List<Avertise>> GetAllAvertise()
        {
            return await _dbContext.Avertises.ToListAsync();
        }

        public async Task<Avertise> GetAvertiseById(int Id)
        {
            return await _dbContext.Avertises.Where(p => p.MaQuangCao.Equals(Id)).FirstOrDefaultAsync();
        }

        public bool UpdAvertise(Avertise Items)
        {
            throw new NotImplementedException();
        }
    }
}
