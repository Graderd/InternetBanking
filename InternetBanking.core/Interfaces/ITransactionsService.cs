using InternetBanking.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.core.Interfaces
{
    public interface ITransactionsService
    {
        Task<List<Transactions>> GetTransactionsAsync();
        Task<Transactions> GetTransactionsByIdAsync(int id);
        Task<bool> AddTransactionsAsync(Transactions transaction);
    }
}
