using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueTeamProject
{
    internal class Item
    {
        private int id { get; }
        private string item_name { get; set; }
        private float item_minimum { get; set; }
        private float item_units { get; set; }
        private float item_price { get; set; }
        private string manufacturer { get; set; }
        private string description { get; set;}
        private byte isMachine { get; set; }
    }
}
