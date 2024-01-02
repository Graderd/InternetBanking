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
    public class KeyCardsService : IKeyCardsService
    {
        public KeyCardsService(InternetBankingDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        private readonly InternetBankingDbContext _dbContext;
        public async Task<bool> AddKeyCardsAsync(KeyCards keyCards)
        {
            await _dbContext.KeyCards.AddAsync(keyCards);
            int inserted = await _dbContext.SaveChangesAsync();
            return inserted > 0;
        }

        public async Task<bool> DelecteKeyCardsAsync(int id)
        {
            KeyCards keyCards = await _dbContext.KeyCards.Where(k => k.CardId == id).FirstOrDefaultAsync();
            if (keyCards != null)
            {
                int delected = await _dbContext.SaveChangesAsync();
                return delected > 0;
            }
            else { return false; }
            
        }

        public async Task<List<KeyCards>> GetKeyCardsAsync()
        {
            return await _dbContext.KeyCards.ToListAsync();
        }

        public async Task<KeyCards> GetKeyCardsAsync(int id)
        {
            KeyCards keyCards = await _dbContext.KeyCards.Where(k => k.CardId != id).FirstOrDefaultAsync();
            if (keyCards != null) return keyCards;

            throw new Exception("Esta tarjeta no existe");
        }
    }
}
