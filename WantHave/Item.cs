using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WantHave
{
    public enum ItemCategories { Books, Hardware, Furniture, Food, Gardening, Pets, Kids, Kitchen, Bathroom, Tools }// list of types of items supported by app
    public enum ItemAvailability { Available, NotAvailable}
    
    public class Item
    {

    #region StaticVars

    //private static int lastItemID = 0;

    #endregion

    #region Properties
    ///<Description>
    ///Item Class is the main class for defining, creating, and managing items
    ///</Description>
    [Key]
    public int ItemID { get; set; }
    public string ItemName { get; set; }
    public DateTime ItemExpiration { get; set; } //expecting to store date and time in this string
    public string ItemDescription { get; set; } //text
    public string ItemImage { get; set; } //future: image file in blob storage   
    public ItemCategories ItemCategory { get; set; } 
    
    public virtual ICollection<Offer> Offers { get; set; }
    #endregion

    #region Constructor
   // public Item()
   // {
   //     ItemID = ++lastItemID; 
   // }

    #endregion


    #region Functions

    public void ChangeItemExpiration(DateTime date)
    {
        ItemExpiration = date;
    }

        

    

    #endregion


}    
}

