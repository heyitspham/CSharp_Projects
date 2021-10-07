using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step275_CallingMethodsAssignment
{
    // 1. Create a class.
    // a. In that class, create three methods, each of which will take one integer parameter in and return an integer.
    // b. The methods should do some math operation on the received parameter.
    // c. Put this class in a separate.cs file in the application.
    public class MathOperation
    {
        // Method to add userInput int by 10.
        public static int Add(int userInput)
        {
            int results = userInput + 10;
            return results;
        }

        // Method to subtract userInput int by 10.
        public static int Subtract(int userInput)
        {
            int results = userInput - 10;
            return results;
        }

        // Method to multiply userInput int by 10.
        public static int Multipy(int userInput)
        {
            int results = userInput * 10;
            return results;
        }

        //public int userInput { get; set; }
    }
}
