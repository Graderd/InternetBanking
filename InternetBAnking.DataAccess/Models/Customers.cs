using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.DataAccess.Models
{
    public class Customers
    {
        public int CustomersId { get; set; }
        public string Identification { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Company { get; set; } = null!;
        public decimal Salary { get; set; } 
        public string Password { get; set; } = null!;
        IEnumerable<Accounts>Acounts { get; set; }

    }
}
