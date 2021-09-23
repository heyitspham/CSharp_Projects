using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step242_ConsoleAppArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select an index number from 0-4 to display the information from the array.");
            int answer = Convert.ToInt16(Console.ReadLine());
            bool goodAnswer = 0 <= answer && answer <= 4;
            string[] stringArray = { "Hello", "Hi", "Hey", "Hi-yah!", "How'dy!" };

            do
            {
                if (goodAnswer)
                {
                    Console.WriteLine(stringArray[answer]);
                }
                else
                {
                    Console.WriteLine("The index you have selected does not exist. Please select again.");
                    answer = Convert.ToInt16(Console.ReadLine());
                    goodAnswer = 0 <= answer && answer <= 4;
                }
            }
            while (!goodAnswer);
            Console.ReadLine();
        }
    }
}
