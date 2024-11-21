using FSK.Reponsitories.Entities;
using FSK.Reponsitories.Interface_Respon;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSK.Reponsitories.Implement_Respon
{
    public class HoCa_Res : IHoCa_Res
    {
        private readonly FengShuiKoiContext _dbContext;

        public HoCa_Res(FengShuiKoiContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public bool AddHoCa(HoCa product)
        {
            try
            {
                _dbContext.HoCas.Add(product);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //throw new NotImplementedException(ex.ToString());
                return false;
            }
        }

        public bool DelHoCa(int Id)
        {
            try
            {
                var objDel = _dbContext.HoCas.Where(p => p.MaHoCa.Equals(Id)).FirstOrDefault();
                if (objDel != null)
                {
                    _dbContext.HoCas.Remove(objDel);
                    _dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
                return false;

            }
        }

        public bool DelHoCa(HoCa product)
        {
            try
            {
                _dbContext.HoCas.Remove(product);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //throw new NotImplementedException(ex.ToString());
                return false;
            }
        }

        public async Task<List<HoCa>> GetAllHoCa()
        {
                return await _dbContext.HoCas.ToListAsync();
        }

        public async Task<HoCa> GetHoCaById(int Id)
        {
            return await _dbContext.HoCas.Where(p => p.MaHoCa.Equals(Id)).FirstOrDefaultAsync();
        }

        public bool UpdHoCa(HoCa product)
        {
            try
            {
                _dbContext.HoCas.Update(product);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
