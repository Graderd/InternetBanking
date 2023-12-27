using InternetBanking.core.Interfaces;
using InternetBanking.DataAccess.DbContexts;
using InternetBanking.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.core.Services
{
    public class CustomersService : ICustomersService
    {
        public CustomersService(InternetBankingDbContext dbContext) 
        {
            _dbcontext = dbContext;
        }
        private readonly InternetBankingDbContext _dbcontext;
        public Task<bool> AddCustomersAsync(Customers customer)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteCustomersAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customers>> GetCustomersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customers> GetCustomersByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateCustomersAsync(Customers customers)
        {
            throw new NotImplementedException();
        }
    }
}
