using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.DataAccess.Models
{
    public class Transactions
    {
        public int TransactionId { get; set; }
        public int OriginAccountId { get; set; }
        public int DestinationAccountId { get; set; }
        public decimal Amount { get; set; }
        public int TransationTypeId { get; set; }
        public string Description { get; set; }
        public DateTime TransationDate { get; set; }
        public IEnumerable<Accounts> Origins { get; set; }
        public IEnumerable<Accounts> Destination { get; set; }

    }
}
