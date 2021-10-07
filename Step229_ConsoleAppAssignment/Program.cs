using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step229_ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i != 11)
            {
                Console.WriteLine("i is " + i + ".");
                i++;
            }

            int j = 1;
            do
            {
                Console.WriteLine("j is " + j + ".");
                j++;
            }
            while (j != 11);

            Console.Read();
        }
    }
}
