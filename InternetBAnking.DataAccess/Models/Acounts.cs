using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.DataAccess.Models
{
    public class Acounts
    {
        public int AccountsId { get; set; }
        public int CustomersId { get; set; }
        public decimal Balance { get; set; }
        public Customers Customers { get; set; } 
        public DateTime CreationDate { get; set; }

    }
}
