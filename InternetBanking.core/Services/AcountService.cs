using InternetBanking.core.Interfaces;
using InternetBanking.DataAccess.DbContexts;
using InternetBanking.DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.core.Services
{
    public class AcountService : IAcountsService
    {
        public AcountService(InternetBankingDbContext dbContext)
        {
            _dbContext =  dbContext;
        }
        private readonly InternetBankingDbContext _dbContext;
        public async Task<bool> AddAcountsAsync(Acounts acounts)
        {
            await _dbContext.Acounts.AddAsync(acounts);
            int inserted = await _dbContext.SaveChangesAsync();
            return inserted > 0;
        }

        public async Task<bool> DeleteAcountsAsync(int id)
        {
            Acounts acounts = await _dbContext.Acounts.Where(a => a.AccountsId == id).FirstOrDefaultAsync();
            if (acounts != null)
            {
                _dbContext.Acounts.Remove(acounts);
                int deleted = await _dbContext.SaveChangesAsync();
                return deleted > 0;
            }
            else { return false; }
        }

        public async Task<List<Acounts>> GetAcountsAsync()
        {
            return await _dbContext.Acounts.ToListAsync();
        }

        public async Task<Acounts> GetAcountsByIdAsync(int id)
        {
            Acounts acounts = await _dbContext.Acounts.Where(a => a.AccountsId == id).FirstOrDefaultAsync();
            if (acounts != null) return acounts;

            throw new Exception("Esta cuenta no existe");
        }

        public async Task<bool> UpdateAcountsAsync(Acounts acounts)
        {
            _dbContext.Entry(acounts).State = EntityState.Modified;
            int updated = await _dbContext.SaveChangesAsync();
            return updated > 0;
        }
    }
}
