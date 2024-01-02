
using InternetBanking.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace InternetBanking.DataAccess.DbContexts
{
    public class InternetBankingDbContext : DbContext
    {
        public InternetBankingDbContext(DbContextOptions<InternetBankingDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Accounts> Accounts { get; set; } = null!;
        public DbSet<Codes> Codes { get; set; } = null!;
        public DbSet<Customers> Customers { get; set; } = null!;
        public DbSet<KeyCards> KeyCards { get; set; } = null!;
        public DbSet<Transactions> Transactions { get; set; } = null!;
        public DbSet<TransactionTypes> TransactionTypes { get; set; } = null!;
        //public override 

    }
}
