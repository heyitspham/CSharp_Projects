using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step222_BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Obtains package weight from customer
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt16(Console.ReadLine());

            // Branching statements to determine package eligibility and quote.
            if (weight > 50) // If package weight is over 50, then it is too heavy to be shipped.
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
                int width = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Please enter the package height:");
                int height = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Please enter the package length:");
                int length = Convert.ToInt16(Console.ReadLine());

                if ((width + height + length) > 50) // If package dimensions are over 50, then it is too big to be shipped.
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    int quote = ((width * height * length * weight) / 100); // Calculates quote for package shipment.

                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
                    Console.WriteLine("Thank you!");
                }
            }
            Console.ReadLine();
        }
    }
}
