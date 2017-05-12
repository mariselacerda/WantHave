using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WantHave
{
    public enum RequestTypes { Want, Borrow}//Wanted, Borrow , Giving Away
    public enum RequestStatuses { Active, Closed }
    public enum RequestUrgencies { NOW, ASAP, Anytime }

    public class Request
    {

 
        #region Properties
        ///<Description>
        ///Item Class is the main class for defining, creating, and managing items
        ///</Description>
        [Key]
        public int RequestID { get; set; }
        public string RequesterName { get; set; }
        public string RequesterEmail { get; set; } //expecting to store date and time in this string
        public string Description { get; set; } //future: image file in blob storage     
        public DateTime RequestExpiration { get; set; }
        public RequestTypes RequestType { get; set; }
        public RequestStatuses Requeststatus { get; set; }
        public RequestUrgencies RequestUrgency { get; set; }
       
        #endregion
    }
}
