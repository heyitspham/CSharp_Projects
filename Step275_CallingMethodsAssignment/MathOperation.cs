using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step275_CallingMethodsAssignment
{
    public class MathOperation
    {
        public static int Add(int userInput)
        {
            int results = userInput + 10;
            return results;
        }

        public static int Subtract(int userInput)
        {
            int results = userInput - 10;
            return results;
        }

        public static int Multipy(int userInput)
        {
            int results = userInput * 10;
            return results;
        }

        public int userInput { get; set; }
    }
}
