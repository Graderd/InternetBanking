using InternetBanking.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.core.Interfaces
{
    public interface ICodesService
    {
        Task<List<Codes>> GetAllCodesAsync();
        Task<Codes> GetCodesByIdAsync(int id);
        Task<bool> AddCodesAsync(Codes codes); 

    }
}
