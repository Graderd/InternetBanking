using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBanking.core.Dtos
{
    public class AccountsInsertDto
    {
        public int CustomersId {  get; set; }
        public decimal Balance {  get; set; }
        public DateTime CreationDate { get; set; }

    }
}
