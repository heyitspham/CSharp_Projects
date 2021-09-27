using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step280_MethodAssignment
{
    // 1. Create a class.
    class Math
    {
        // 1a. In that class, create a method that takes two integers as parameters. Make one of them optional. Have the method do a math operation and return an integer result.
        public static int MathOp(int input01, int input02 = 10)
        {
            int results = input01 * input02;
            return results;
        }
    }
}
