using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamProject
{
    internal class User
    {
        public int account_id { get; set; }
        public string username { get; set; }
        public string password_hash { get; set; }
        public string security1_hash { get; set; }
        public string security2_hash { get; set; }
        public string security3_hash { get; set; }
        public int isManager { get; set; }
    }
}
