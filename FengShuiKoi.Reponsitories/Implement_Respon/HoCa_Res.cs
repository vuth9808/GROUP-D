using FengShuiKoi.Reponsitories.Entities;
using FengShuiKoi.Reponsitories.IReponsitories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FengShuiKoi.Reponsitories.Implement_Respon
{
    public class HoCa_Res : IHoCa_Res
    {
        private readonly FengShuiKoiContext _dbContext;

        public HoCa_Res(FengShuiKoiContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public bool AddHoCa(NhanVien account)
        {
            try
            {
                _dbContext.NhanViens.Add(account);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
            }
        }

        public bool DelNhanvien(int Id)
        {
            try
            {
                var objDel = _dbContext.NhanViens.Where(p => p.MaNhanVien.Equals(Id)).FirstOrDefault();
                if (objDel != null)
                {
                    _dbContext.NhanViens.Remove(objDel);
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

        public bool DelNhanvien(NhanVien account)
        {
            try
            {
                _dbContext.NhanViens.Remove(account);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException(ex.ToString());
                return false;
            }
        }

        public async Task<List<NhanVien>> GetAllNhanVien()
        {
            return await _dbContext.NhanViens.ToListAsync();
        }

        public async Task<NhanVien> GetNhanvienById(int Id)
        {
            return await _dbContext.NhanViens.Where(p => p.MaNhanVien.Equals(Id)).FirstOrDefaultAsync();
        }

        public bool UpdNhanvien(NhanVien account)
        {
            try
            {
                _dbContext.NhanViens.Update(account);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
