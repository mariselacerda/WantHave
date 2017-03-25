using System;

namespace WantHave
{

    public Class Item
    {

                #region Properties
        ///<Description>
        ///Item Class is the main class for defining, creating, and managing items
        ///</Description>

    public string ItemName { get; set; }
    public enum ItemCategory { Books, Hardware, Furniture, Food, Gardening, Pets, Kids, Kitchen, Bathroom, Tools }// list of types of items supported by app
    public string ItemExpiration { get; set; } //expecting to store date and time in this string
    public byte ItemStatus { get; private set; } //Availability of item 0=Not Available, 1 = Available
    public enum ItemRequestType { Wanting, Borrowing, Giving }//Wanted, Borrow , Giving Away
    public string ItemDescription { get; set; } //text
    public string ItemImage { get; set; } //future: image file in blob storage     
    #endregion
    #region Functions

    public void SetItemName (string NameOfItem) {
        ItemName = NameOfItem;
    }

    public void SetItemExpiration(string date) {
        ItemExpiration = DateTime;
    }



    

    #endregion


}    
}

