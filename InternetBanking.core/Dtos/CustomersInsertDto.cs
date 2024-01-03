using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.core.Dtos
{
    public class CustomersInsertDto 
    {
        public string Identification { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Company { get; set; } = null!;
        public decimal Salary { get; set; }
        public string Password { get; set; } = null!;
    }
}
