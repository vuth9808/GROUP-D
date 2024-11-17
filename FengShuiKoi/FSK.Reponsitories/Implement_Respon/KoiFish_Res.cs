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
    public class KoiFish_Res : IKoiFish_Res
    {
        private readonly FengShuiKoiContext _dbContext;

        public KoiFish_Res(FengShuiKoiContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public bool AddKoiFish(KoiFish product)
        {
            try
            {
                _dbContext.KoiFishes.Add(product);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //throw new NotImplementedException(ex.ToString());
                return false;
            }
        }

        public bool DelKoiFish(int Id)
        {
            try
            {
                var objDel = _dbContext.KoiFishes.Where(p => p.MaCaKoi.Equals(Id)).FirstOrDefault();
                if (objDel != null)
                {
                    _dbContext.KoiFishes.Remove(objDel);
                    _dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                //throw new NotImplementedException(ex.ToString());
                return false;

            }
        }

        public bool DelKoiFish(KoiFish product)
        {
            try
            {
                _dbContext.KoiFishes.Remove(product);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //throw new NotImplementedException(ex.ToString());
                return false;
            }
        }

        public async Task<List<KoiFish>> GetAllKoiFish()
        {
            return await _dbContext.KoiFishes.ToListAsync();
        }

        public async Task<KoiFish> GetKoiFishById(int Id)
        {
            return await _dbContext.KoiFishes.Where(p => p.MaCaKoi.Equals(Id)).FirstOrDefaultAsync();
        }

        public bool UpdKoiFish(KoiFish product)
        {
            try
            {
                _dbContext.KoiFishes.Update(product);
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
