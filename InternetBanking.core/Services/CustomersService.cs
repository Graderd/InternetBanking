using AutoMapper;
using InternetBanking.core.Dtos.Customers;
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
    public class CustomersService : ICustomersService
    {
        private readonly InternetBankingDbContext _dbcontext;
        private readonly IMapper mapper;
        public CustomersService(InternetBankingDbContext dbContext) 
        {
            _dbcontext = dbContext;
        }
        public async Task<bool> AddCustomersAsync(CustomersInsertDto customers)
        {
            var customerEntity = mapper.Map<Customers>(customers);

            await _dbcontext.Customers.AddAsync(customerEntity);
            int inserted = await _dbcontext.SaveChangesAsync();
            return inserted > 0;
        }

        public async Task<bool> DeleteCustomersAsync(int id)
        {
            Customers customers = await _dbcontext.Customers.Where(c => c.CustomersId == id).FirstOrDefaultAsync();
            if(customers != null)
            {
                _dbcontext.Customers.Remove(customers);
                int delected = await _dbcontext.SaveChangesAsync();
                return delected > 0;
            }
            else { return false; }
        }

        public async Task<List<Customers>> GetCustomersAsync()
        {
            return await _dbcontext.Customers.ToListAsync();
        }

        public async Task<Customers> GetCustomersByIdAsync(int id)
        {
            Customers customers = await _dbcontext.Customers.Where(c => c.CustomersId == id).FirstOrDefaultAsync();
            if(customers != null ) return customers;

            throw new Exception("Este usuario no existe");        
        }

        public async Task<bool> UpdateCustomersAsync(Customers customers)
        {
            _dbcontext.Entry(customers).State = EntityState.Modified;
            int updated = await _dbcontext.SaveChangesAsync();
            return updated > 0;
        }
    }
}
