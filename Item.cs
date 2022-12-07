using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamProject
{
    internal class Item
    {
        public int id { get; set; }
        public string item_name { get; set; }
        public float item_minimum { get; set; }
        public float item_units { get; set; }
        public float item_price { get; set; }
        public string manufacturer { get; set; }
        public string description { get; set;}
        public byte isMachine { get; set; }
    }
}
