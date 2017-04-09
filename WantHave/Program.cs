using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WantHave
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Welcome to the Want Have Application");
            Console.WriteLine("Use this application to give away, ask for or borrow items from people in your local community");
            Console.WriteLine(); //create some space for readability
           Console.WriteLine("Please select from the following options:");
            Console.WriteLine("1:Post A New Request" + " 2:View All Items" + " 3:View My Items" + "4:Exit");
            var option = Console.Read();

            while (true)
            {
                switch (option)
                {
                    case "1":
                        var requesttypes = Enum.GetNames(typeof(ItemRequestType));
                        Console.WriteLine("Select a request type:");
                        for (var i = 0; i<(requesttypes.Length-1); i++)
                        {
                            Console.WriteLine($"{i}: {requesttypes[i]}");
                        }
                        var requesttype = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Please provide an item name:");
                        string itemname = Console.ReadLine();
                        Console.WriteLine("Please provide an item description:");
                        string itemdescription = Console.ReadLine();
                        Console.WriteLine("Please provide an item expiration:");
                        string itemexpiration = Console.ReadLine();
                        break;
                    case "2":
                        //collect item information
                        break;
                    case "3";
                        //collect item information
                        break;
                    case "4";
                        return;

                }
            }

        }
    }
}
