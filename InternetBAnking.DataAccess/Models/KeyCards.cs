using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.DataAccess.Models
{
    public class KeyCards
    {
        public int CardId { get; set; }
        public int CustomersId { get; set; }
        public Customers Customers { get; set; }
        public List<Codes> Codes { get; set; } = new List<Codes>();
    }
}
