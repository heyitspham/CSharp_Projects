using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step284_ClassAssignment
{
    // 1. Create a class.
    public class Math
    {
        // 1a. In that class, create a void method that outputs an integer.
        public void MathOp(int input, out int output)
        {
            // 1b. Have the method divide the data passed to it by 2.
            output = input / 2;
        }

        // 4. Create a method with output parameters.
        // 5. Overload a method.
        public void MathOp(out int output, int input = 2)
        {
            // 1b. Have the method divide the data passed to it by 2.
            output = input / 2;
        }
    }
}
