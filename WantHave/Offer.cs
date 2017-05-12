using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WantHave
{
    public enum OfferTypes { Give, Sell }
    public enum OfferStatuses { Active, Closed }
    public class Offer
    {

        [Key]
        public int OfferID { get; set; }
        public string OffererName { get; set; }
        public string OffererEmail { get; set; } //expecting to store date and time in this string
        public DateTime OfferExpiration { get; set; } //expecting to store date and time in this string 
        [ForeignKey("Item")]
        public int ItemId { get; set; }
        public virtual Item Item { get; set; } //"virtual" sets up a foriegn key column in the transaction table and a relationship between a request and an item
    }
}
