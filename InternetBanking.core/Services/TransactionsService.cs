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
    internal class TransactionsService : ITransactionsService
    {
        public TransactionsService(InternetBankingDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        private readonly InternetBankingDbContext _dbContext;
        public async Task<bool> AddTransactionsAsync(Transactions transaction)
        {
            await _dbContext.Transactions.AddAsync(transaction);
            int inserted = await _dbContext.SaveChangesAsync();
            return inserted > 0;
        }

        public async Task<List<Transactions>> GetTransactionsAsync()
        {
            return await _dbContext.Transactions.ToListAsync();
        }

        public async Task<Transactions> GetTransactionsByIdAsync(int id)
        {
            Transactions transactions = await _dbContext.Transactions.Where(t => t.TransactionId == id).FirstOrDefaultAsync();
            if(transactions != null) return transactions;
            throw new Exception("Error");
        }
    }
}
