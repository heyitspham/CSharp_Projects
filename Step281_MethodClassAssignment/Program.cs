using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step281_MethodClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // Requested input, converted input to int16, and then assigned input to 'input01' int.
            Console.WriteLine("Hi, Please input the 1st number:");
            int input01 = Convert.ToInt16(Console.ReadLine());

            // Requested input, converted input to int16, and then assigned input to 'input02' int.
            Console.WriteLine("Please input the 2nd number:");
            int input02 = Convert.ToInt16(Console.ReadLine());

            // 2. In the Main() method of the console app, instantiate the class.
            Math math = new Math();

            // 3. Call the method in the class, passing in two numbers.
            // 4. Call the method in the class, specifying the parameters by name.
            math.MathOp(input01: input01, input02: input02);

            Console.ReadLine();
        }
    }
}
