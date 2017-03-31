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
            Console.WriteLine("1:Give" + " 2:Borrow" + " 3:Want");
            var option = Console.Read();

            var newItem = new Item();
            switch (option)
            {
                case "1":
                    //collect item information
                    break;
                case "2":
                    //collect item information
                    break;
                case "3";
                    //collect item information
                    break;
            }

        }
    }
}
