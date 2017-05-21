using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WantHave
{
    class Coordinator
    {
        //private static List<Item>Items = new List<Item>();

        private static WantHaveModel db = new WantHaveModel(); 
        private static Item CreateItem(string itemName, string itemDescription, DateTime itemExpiration, ItemCategories category)
        {
            if (string.IsNullOrEmpty(itemName))
            {
                throw new ArgumentNullException("missing item name");
            }
            //var Item = new Item {ItemName = itemName, ItemDescription = itemDescription, ItemExpiration = itemExpiration };
            //Items.Add(Item);
            if (string.IsNullOrEmpty(itemDescription))
            {
                throw new ArgumentNullException("missing item description");
            }
            if (string.IsNullOrEmpty(Convert.ToString(itemExpiration)))
            {
                throw new ArgumentNullException("missing item expiration date");
            }

            var CheckItemCategory = Enum.GetName(typeof(ItemCategories), category);
            if (string.IsNullOrEmpty(CheckItemCategory))
            {
                throw new ArgumentNullException("missing item category");
            }

            var item = new Item { ItemName = itemName, ItemDescription = itemDescription, ItemExpiration = itemExpiration, ItemCategory = (ItemCategories)category };

            db.Items.Add(item);
            db.SaveChanges(); 

            return item;
        }

        public static Request CreateRequest(string requesterName, string requesterEmail, string description, DateTime expirationDate, RequestTypes typeOfRequest, RequestUrgencies requestUrgency)
        {

            //TO DO; write error handling for missing information in params
            //TO DO; verify that DateTime is in future and not in past

            //set request status to active on new request always
            var request = new Request { RequesterName = requesterName, RequesterEmail = requesterEmail, Description = description, RequestExpiration = expirationDate, RequestType = typeOfRequest, RequestUrgency = requestUrgency, Requeststatus = 0 };


            db.Requests.Add(request);
            db.SaveChanges();
            return request;

        }

        public static Offer CreateOffer(string offername, string offeremail, DateTime offerexpiration, int itemid, OfferTypes offertype)
        {

            var offer = new Offer { OfferStatus= 0, OfferType = (OfferTypes)offertype, OffererName = offername, OffererEmail = offeremail, OfferExpiration = offerexpiration, ItemId = itemid };
            db.Offers.Add(offer);
            db.SaveChanges(); 
            return offer; 
        }
        public static void NewRequest()
        {

        }

        public static void UpdateRequest()
        {
            //to do: write code block to update an existing request
        }
        public static List<Item> GetAllItems()
        {
            //To Do; get list of items from db
            List<Item> items = new List<Item>(); 
            return items;
        }

        public static Item GetActiveItems()
        {
            var Item = new Item();
            return Item;
        }

        public static Item GetItem(int itemid)
        {
            var Item = new Item();
            return Item;
        }

    }
}
