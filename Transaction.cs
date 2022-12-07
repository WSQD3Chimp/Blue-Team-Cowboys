using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamProject
{
    internal class Transaction
    {
        public int transaction_id { get; set; }
        public int account_id { get; set; }
        public int item_id { get; set; }
        public string operation_type { get; set; }
        public decimal unit_change { get; set; }
        public DateTime date { get; set; }
    }
}
