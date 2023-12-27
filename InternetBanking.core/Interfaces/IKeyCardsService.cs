using InternetBanking.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.core.Interfaces
{
    public interface IKeyCardsService
    {
        Task<List<KeyCards>> GetKeyCardsAsync();
        Task<KeyCards> GetKeyCardsAsync(int id);
        Task<bool> AddKeyCardsAsync(KeyCards keyCards);
        Task<bool> DelecteKeyCardsAsync(int id);
    }
}
