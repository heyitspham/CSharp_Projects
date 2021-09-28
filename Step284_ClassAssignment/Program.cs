using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step284_ClassAssignment
{
    // 6. Declare a class to be static.
    static class Program
    {
        static void Main(string[] args)
        {
            // 2. In the Main() method, instantiate that class.
            Math math = new Math();

            // 3. Have the user enter a number.
            Console.WriteLine("Hi, Please input a number to be divided by 2:");
            string inputAsString = Console.ReadLine();
            int output;

            if (inputAsString == "")
            {
                // 3a. Call the method on that number.
                math.MathOp(out output);
                Console.WriteLine($"Since no input was provided, the default input was 2.\nHere is the result: 2 / 2 = {output}.");
            }
            else
            {
                int input = Convert.ToInt16(inputAsString);
                math.MathOp(input, out output);
                Console.WriteLine($"Here is the result: {input} / 2 = {output}.");
                // 3b. Display the output to the screen. It should be the entered number, divided by two.
            }
            Console.ReadLine();
        }
    }
}
