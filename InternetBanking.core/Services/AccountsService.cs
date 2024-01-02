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
    public class AccountsService : IAccountsService
    {
        public AccountsService(InternetBankingDbContext dbContext)
        {
            _dbContext =  dbContext;
        }
        private readonly InternetBankingDbContext _dbContext;
        public async Task<bool> AddAccountsAsync(Accounts accounts)
        {
            await _dbContext.Accounts.AddAsync(accounts);
            int inserted = await _dbContext.SaveChangesAsync();
            return inserted > 0;
        }

        public async Task<bool> DeleteAccountsAsync(int id)
        {
            Accounts  accounts = await _dbContext.Accounts.Where(a => a.AccountsId == id).FirstOrDefaultAsync();
            if (accounts != null)
            {
                _dbContext.Accounts.Remove(accounts);
                int deleted = await _dbContext.SaveChangesAsync();
                return deleted > 0;
            }
            else { return false; }
        }

        public async Task<List<Accounts>> GetAccountsAsync()
        {
            return await _dbContext.Accounts.ToListAsync();
        }

        public async Task<Accounts> GetAccountsByIdAsync(int id)
        {
            Accounts accounts = await _dbContext.Accounts.Where(a => a.AccountsId == id).FirstOrDefaultAsync();
            if (accounts != null) return accounts;

            throw new Exception("Esta cuenta no existe");
        }

        public async Task<bool> UpdateAccountsAsync(Accounts accounts)
        {
            _dbContext.Entry(accounts).State = EntityState.Modified;
            int updated = await _dbContext.SaveChangesAsync();
            return updated > 0;
        }
    }
}
