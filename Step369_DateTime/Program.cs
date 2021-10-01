using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step369_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Prints the current date and time to the console.
            Console.WriteLine("The current time is: {0}.", DateTime.Now);

            // 2. Asks the user for a number.
            Console.WriteLine("Hi, please give a number so we can print the time it will be from now until that number of X hours:");
            int userInput = Convert.ToInt16(Console.ReadLine());

            // 3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.
            Console.WriteLine("The time it will be in {0} hour(s) is: {1}.", userInput, DateTime.Now.AddHours(userInput));
            Console.ReadLine();
        }
    }
}
