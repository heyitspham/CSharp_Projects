using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step324_ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // 2. Prompt the user to enter the current day of the week.
                Console.WriteLine("Hi, please enter the current day of the week:");
                string currentDay = Console.ReadLine();

                // 3. Assign the value to a variable of that enum data type you just created.
                Day day = (Day)Enum.Parse(typeof(Day), currentDay, true);

                Console.WriteLine($"You have entered '{day}' as the current day of the week.");
                Console.ReadLine();
            }
            catch
            {
                // 4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week.” to the console if an error occurs.
                // The code "Enum.GetValues(typeof(Day)).Cast<Day>().ToList()" converted the "Day" enum to a list, so it can be printed with the "string.join()" method
                Console.WriteLine("Please enter an actual day of the week: ");
                Console.WriteLine(String.Join(", ", Enum.GetValues(typeof(Day)).Cast<Day>().ToList()));
                Console.ReadLine();
            }
        }
    }
}
