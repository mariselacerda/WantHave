using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WantHave
{
    class Coordinator
    {
        public static Item CreateItem(string itemName, string itemDescription, string itemExpiration)
        {
            var Item = new Item {ItemName = itemName, ItemDescription = itemDescription, ItemExpiration = itemExpiration };

            return Item; 
        }

    }
}
