using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step275_CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, to which number would you like us to add, subtract, and multiply by 10?");
            int userInput = Convert.ToInt16(Console.ReadLine());

            int addResults = MathOperation.Add(userInput);
            Console.WriteLine($"{userInput} added by 10 is {addResults}.");

            int subtractResults = MathOperation.Subtract(userInput);
            Console.WriteLine($"{userInput} subtracted by 10 is {subtractResults}.");

            int multiplyResults = MathOperation.Multipy(userInput);
            Console.WriteLine($"{userInput} multipled by 10 is {multiplyResults}.");

            Console.ReadLine();
        }
    }
}
