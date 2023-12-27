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
    public class CodesService : ICodesService
    {
        public CodesService(InternetBankingDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        private readonly InternetBankingDbContext _dbContext;
        public async Task<bool> AddCodesAsync(Codes codes)
        {
            await _dbContext.Codes.AddAsync(codes);
            int inserted = await _dbContext.SaveChangesAsync();
            return inserted > 0;
        }

        public async Task<List<Codes>> GetAllCodesAsync()
        {
            return await _dbContext.Codes.ToListAsync();
        }

        public async Task<Codes> GetCodesByIdAsync(int id)
        {
            Codes  codes = await _dbContext.Codes.Where(c => c.CodeId == id).FirstOrDefaultAsync();
            if(codes != null) return codes;
            throw new Exception("Error");
        }
    }
}
