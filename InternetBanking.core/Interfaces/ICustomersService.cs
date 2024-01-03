using InternetBanking.core.Dtos.Customers;
using InternetBanking.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.core.Interfaces
{
    public interface ICustomersService
    {
        Task<List<Customers>> GetCustomersAsync();
        Task<Customers> GetCustomersByIdAsync(int id);
        Task<bool> AddCustomersAsync(CustomersInsertDto customer);
        Task<bool> UpdateCustomersAsync(Customers customers);
        Task<bool> DeleteCustomersAsync(int id);
    }
}
