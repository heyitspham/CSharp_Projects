using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step280_MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Ask the user to input two numbers, one at a time. Let them know they need not enter anything for the second number.
            Console.WriteLine("Hi, Please provide us with two numbers (where the 2nd number is optional), so we can multiply them. What is your first number?");
            int input01 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("If you would like to, please provide us with your 2nd number. If not, please leave it blank and press Enter.");
            string input02AsString = Console.ReadLine();

            // 2. In the Main() method of the console app, instantiate the class.
            Math math = new Math();
            
            // 4. Call the method in the class, passing in the one or two numbers entered.
            if (input02AsString == "")
            {
                int output = math.MathOp(input01);
                Console.WriteLine($"The 1st number you provided was '{input01}'. The 2nd number was not provided so the default was 10. The product of those two numbers is {output}.\n");
            }
            else if (input02AsString == " ")
            {
                int output = math.MathOp(input01);
                Console.WriteLine($"The 1st number you provided was '{input01}'. The 2nd number was not provided so the default was 10. The product of those two numbers is {output}.\n");
            }
            else
            {
                int input02 = Convert.ToInt16(input02AsString);
                int output = math.MathOp(input01, input02);
                Console.WriteLine($"The numbers you provided were '{input01}' and '{input02}'. The product of those two numbers is {output}.\n");
            }

            Console.ReadLine();
        }
    }
}

            // 5. Try various combinations of numbers on the code, including having no second number.

// 6. Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code.
