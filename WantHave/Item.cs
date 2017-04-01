using System;

namespace WantHave
{
    enum ItemRequestType { Want, Borrow, Give }//Wanted, Borrow , Giving Away
    enum ItemCategory { Books, Hardware, Furniture, Food, Gardening, Pets, Kids, Kitchen, Bathroom, Tools }// list of types of items supported by app
    
    class Item
    {

    #region StaticVars

    private static int lastItemID = 0;

    #endregion

    #region Properties
    ///<Description>
    ///Item Class is the main class for defining, creating, and managing items
    ///</Description>

    public int ItemID { get; private set}
    public string ItemName { get; set; }
    public byte ItemStatus { get; private set; } //Availability of item 0=Not Available, 1 = Available
    public string ItemExpiration { get; set; } //expecting to store date and time in this string
    public string ItemDescription { get; set; } //text
    public string ItemImage { get; set; } //future: image file in blob storage     
    #endregion

    #region Constructor
    public Item()
    {
        ItemID = ++lastItemID; 
    }

    #endregion


    #region Functions

    public void SetItemName (string nameOfItem) {
        ItemName = nameOfItem;
    }

    public void SetItemExpiration(string date) {
        ItemExpiration = date;
    }



    

    #endregion


}    
}

