using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBAnking.DataAccess.Models
{
    public class KeyCards
    {
        public int CardId { get; set; }
        public int CustomersId { get; set; }
        public Customers Customers { get; set; }
        public IEnumerable<Codes> Codes { get; set; }
    }
}
