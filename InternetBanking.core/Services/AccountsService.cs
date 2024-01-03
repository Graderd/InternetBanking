using AutoMapper;
using InternetBanking.core.Dtos;
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
        private readonly InternetBankingDbContext _dbContext;
        private readonly IMapper mapper;
        public AccountsService(InternetBankingDbContext dbContext, IMapper mapper)
        {
            _dbContext =  dbContext;
        }
        
        public async Task<bool> AddAccountsAsync(AccountsInsertDto accounts)
        {
            var acountEmntity = mapper.Map<Accounts>(accounts);

            await _dbContext.Accounts.AddAsync(acountEmntity);
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

    }
}
