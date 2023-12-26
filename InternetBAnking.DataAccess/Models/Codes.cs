using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetBAnking.DataAccess.Models
{
    public class Codes
    {
        public int CodeId { get; set; }
        public int CardId { get; set; }
        public string Code { get; set; }
        public KeyCards KeyCards { get; set; }
    }
}
