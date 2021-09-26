using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step263_ConsoleAppStringsAndIntegersAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 1. Create a list of integers. Ask the user for a number to divide each number in the list by.
                // a. Write a loop that takes each integer in the list, divides it by the number the user entered, and displays the result to the screen.
                Console.WriteLine("Hi, please pick a number to divide each number in our list by.");
                Console.WriteLine("The list is shown below:");
                List<int> listofInts = new List<int>() { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50};
                Console.WriteLine(String.Join(", ", listofInts));
                int divider = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Thank you. The results of our math are: \n");
            
                foreach (int integer in listofInts)
                {
                    int results = integer / divider;
                    Console.WriteLine($"{integer} divided by {divider} is: {results}");
                }
                Console.ReadLine();
            }
            // 5. Now put the loop in a try/catch block. Below and outside of the try/catch block, make the program print a message to the display to let you know the program has emerged from the try/catch block and continued on with program execution. In the catch block, display the error message to the screen. Then try various combinations of user input: valid numbers, zero and a string. Ensure the proper error messages display on the screen, and that the code after the try/catch block gets executed.
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Solution: We cannot divide the numbers by a 0. Please type a number greater than 0.\n");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Solution: We cannot divide the numbers by a string. Please type a number instead.\n");
            }
            Console.WriteLine("We are now outside of the Try-Catch block.");
            Console.ReadLine();
        }
    }
}

// 2. Run the code, entering in non-zero numbers as the user. Look at the displayed results.
// 3. Run the code again, entering in zero as the number to divide by. Note any error messages you get.
// 4. Run the code once again, entering in a string as the number to divide by. Note any error messages you get.
