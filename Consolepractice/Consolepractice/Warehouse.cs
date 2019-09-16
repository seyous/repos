using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolepractice
{
    class Warehouse
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Warehouse(int ID, string name )
        {
            this.ID = ID;
            this.Name = name;
        }
        public item FindandReturn(int itemID)
        {
            item returnitem = new item() { ID = itemID, Name = "Microsoft office"};
            return returnitem;
        }


    }
}
