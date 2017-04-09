using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WantHave
{
    class Coordinator
    {
        private static List<Item>Items = new List<Item>();
        public static Item CreateItem(string itemName, string itemDescription, string itemExpiration)
        {
            var Item = new Item {ItemName = itemName, ItemDescription = itemDescription, ItemExpiration = itemExpiration };
            Items.Add(Item);
            return Item;
        }

        public static List<Item> GetAllItems()
        {
            return Items;
        }
    }
}
