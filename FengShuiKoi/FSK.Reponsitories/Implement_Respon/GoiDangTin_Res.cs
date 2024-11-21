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
    public class GoiDangTin_Res : IGoiDangTin_Res
    {
        private readonly FengShuiKoiContext _dbContext;

        public GoiDangTin_Res(FengShuiKoiContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public bool AddGoiDangTin(GoiDangTin Items)
        {
            try
            {
                _dbContext.GoiDangTins.Add(Items);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DelGoiDangTin(int Id)
        {
            try
            {
                var objDel = _dbContext.GoiDangTins.Where(p => p.MaGoi.Equals(Id)).FirstOrDefault();
                if (objDel != null)
                {
                    _dbContext.GoiDangTins.Remove(objDel);
                    _dbContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;

            }
        }

        public bool DelGoiDangTin(GoiDangTin Items)
        {
            try
            {
                _dbContext.GoiDangTins.Remove(Items);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                
            }
        }

        public async Task<List<GoiDangTin>> GetAllGoiDangTin()
        {
            return await _dbContext.GoiDangTins.ToListAsync();
        }

        public async Task<GoiDangTin> GetGoiDangTinById(int Id)
        {
            return await _dbContext.GoiDangTins.Where(p => p.MaGoi.Equals(Id)).FirstOrDefaultAsync();
        }

        public bool UpdGoiDangTin(GoiDangTin Items)
        {
            try
            {
                _dbContext.GoiDangTins.Update(Items);
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
