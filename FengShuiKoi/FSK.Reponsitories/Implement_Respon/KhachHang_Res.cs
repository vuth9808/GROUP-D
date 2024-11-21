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
    public class KhachHang_Res : IKhachHang_Res
    {
        private readonly FengShuiKoiContext _dbContext;

        public KhachHang_Res(FengShuiKoiContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public bool AddKhachHang(KhachHang account)
        {
            try
            {
                _dbContext.KhachHangs.Add(account);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //throw new NotImplementedException(ex.ToString());
                return false;
            }
        }

        public bool DelKhachHang(int Id)
        {
            try
            {
                var objDel = _dbContext.KhachHangs.Where(p => p.MaKhachHang.Equals(Id)).FirstOrDefault();
                if (objDel != null)
                {
                    _dbContext.KhachHangs.Remove(objDel);
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

        public bool DelKhachHang(KhachHang account)
        {
            try
            {
                _dbContext.KhachHangs.Remove(account);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                //throw new NotImplementedException(ex.ToString());
                return false;
            }
        }

        public async Task<List<KhachHang>> GetAllKhachHang()
        {
            return await _dbContext.KhachHangs.ToListAsync();
        }

        public async Task<KhachHang> GetKhachHangById(int Id)
        {
            return await _dbContext.KhachHangs.Where(p => p.MaKhachHang.Equals(Id)).FirstOrDefaultAsync();
        }

        public bool UpdKhachHang(KhachHang account)
        {
            try
            {
                _dbContext.KhachHangs.Update(account);
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
