using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step279_MainMethodAssignment
{
    // 1. Create a class.
    class Math
    {
        // 1a. In that class, create a method that will take in an integer, create a math operation for this integer (addition, subtraction, etc.), then return the answer as an integer.
        public static int MathOp(int userInputAsInt)
        {
            int results = userInputAsInt + 10;
            return results;
        }

        // 3. Add a second method to the class with the same name that will take in a decimal, create a different math operation for it, then return the answer as an integer.
        public static int MathOp(decimal userInputAsDecimal)
        {
            int results = Convert.ToInt16(userInputAsDecimal - 10);
            return results;
        }

        // 5. Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, do a different math operation to it, then return the answer as an integer.
        public static int MathOp(string userInputAsString)
        {
            int userInput = Convert.ToInt16(userInputAsString);
            int results = userInput * 10;
            return results;
        }

    }
}
