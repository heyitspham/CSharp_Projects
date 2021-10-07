using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step279_MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method of the console app, instantiate the class and call the one method, passing in an integer. Display the result to the screen.
            Console.WriteLine("Hi, Please give us an integer to add to 10.");
            int userInput01 = Convert.ToInt16(Console.ReadLine());
            int results01 = Math.MathOp(userInputAsInt: userInput01);
            Console.WriteLine($"{userInput01} added by 10 is {results01}.");
            Console.ReadLine();

            // 4. In the Main() method of the console app, instantiate the class and call the second method, passing in a decimal. Display the result to the screen.
            Console.WriteLine("Please give us a decimal to subtract by 10.");
            decimal userInput02 = Convert.ToDecimal(Console.ReadLine());
            int results02 = Math.MathOp(userInputAsDecimal: userInput02);
            Console.WriteLine($"{userInput02} subtracted by 10 is {results02}.");
            Console.ReadLine();

            // 6. In the Main() method of the console app, instantiate the class and call the third method, passing in a string that equates to an integer. Display the result to the screen.
            Console.WriteLine("Please give us a number to multiply by 10.");
            string userInput03 = Console.ReadLine();
            int results03 = Math.MathOp(userInputAsString: userInput03);
            Console.WriteLine($"{userInput03} multipled by 10 is {results03}.");
            Console.ReadLine();
        }
    }
}

