using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step275_CallingMethodsAssignment
{
    class Program
    {
        // 2. In the Main() program, ask the user what number they want to do the math operations on.
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, to which number would you like us to add, subtract, and multiply by 10?");
            int userInput = Convert.ToInt16(Console.ReadLine());

            // 3. Call each method in turn, passing the user input to the method. Display the returned integer to the screen.
            // calling Add() method to add the userInput int by 10, then assigning the results to the addResults int.
            int addResults = MathOperation.Add(userInput);
            Console.WriteLine($"{userInput} added by 10 is {addResults}.");

            // calling Subtract() method to subtract the userInput int by 10, then assigning the results to the subtractResults int.
            int subtractResults = MathOperation.Subtract(userInput);
            Console.WriteLine($"{userInput} subtracted by 10 is {subtractResults}.");

            // calling Multiply() method to multiply the userInput int by 10, then assigning the results to the multiplyResults int.
            int multiplyResults = MathOperation.Multipy(userInput);
            Console.WriteLine($"{userInput} multipled by 10 is {multiplyResults}.");

            Console.ReadLine();
        }
    }
}
