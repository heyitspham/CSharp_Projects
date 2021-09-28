using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step281_MethodClassAssignment
{
    // 1. Create a class.
    public class Math
    {
        // 1a. In that class, create a void method that takes two integers as parameters.
        public void MathOp(int input01, int input02)
        {
            // 1b. Have the method do a math operation on the first integer
            int result = input01 * 10;
            Console.WriteLine($"The first input '{input01}' was multiplied by 10, and the result is: {result}");
            
            // 1c. and display the second integer to the screen.
            Console.WriteLine($"The second input was: {input02}");
        }
    }
}
