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
            Console.WriteLine("Please select an index number from 0-4 to display the information from the array of strings.");
            int answer1 = Convert.ToInt16(Console.ReadLine());
            bool goodAnswer1 = 0 <= answer1 && answer1 <= 4;
            string[] stringArray = { "Hello", "Hi", "Hey", "Hi-yah!", "How'dy!" };

            do
            {
                if (!goodAnswer1)
                {
                    Console.WriteLine("The index you have selected does not exist. Please select again.");
                    answer1 = Convert.ToInt16(Console.ReadLine());
                    goodAnswer1 = 0 <= answer1 && answer1 <= 4;
                }
            }
            while (!goodAnswer1);
            Console.WriteLine(stringArray[answer1]);

            Console.WriteLine("Please select an index number from 0-4 to display the information from the array of integers.");
            int answer2 = Convert.ToInt16(Console.ReadLine());
            bool goodAnswer2 = 0 <= answer2 && answer2 <= 4;
            int[] intArray = { 5, 10, 15, 20, 25 };

            do
            {
                if (!goodAnswer2)
                {
                    Console.WriteLine("The index you have selected does not exist. Please select again.");
                    answer2 = Convert.ToInt16(Console.ReadLine());
                    goodAnswer2 = 0 <= answer2 && answer2 <= 4;
                }
            }
            while (!goodAnswer2);
            Console.WriteLine(intArray[answer2]);

            Console.WriteLine("Please select an index number from 0-4 to display the information from the list of strings.");
            int answer3 = Convert.ToInt16(Console.ReadLine());
            bool goodAnswer3 = 0 <= answer3 && answer3 <= 4;
            List<string> stringList = new List<string>();
            stringList.Add("Goodbye");
            stringList.Add("Bye");
            stringList.Add("Later");
            stringList.Add("See-yah!");
            stringList.Add("Buh'bye!");

            do
            {
                if (!goodAnswer3)
                {
                    Console.WriteLine("The index you have selected does not exist. Please select again.");
                    answer3 = Convert.ToInt16(Console.ReadLine());
                    goodAnswer3 = 0 <= answer3 && answer3 <= 4;
                }
            }
            while (!goodAnswer3);
            Console.WriteLine(stringList[answer3]);
            Console.Read();
        }
    }
}
