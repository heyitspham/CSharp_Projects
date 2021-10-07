using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step383_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a const variable.
            const string myName = "Vinh Pham";

            // 2. Create a variable using the keyword “var.”
            var datetime = new DateTime();
            datetime = DateTime.Now;

            Class1 class1 = new Class1(myName);

            Console.WriteLine($"My name is {class1.myName},\nand the current time is {class1.dateTime}");

            Console.ReadLine();
        }
    }
}
