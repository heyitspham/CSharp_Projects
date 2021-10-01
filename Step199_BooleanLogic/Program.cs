using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step199_BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi, let's find out if you are qualified for our auto insurance.");

            // Obtains age from applicant.
            Console.WriteLine("(1/3) What is your age?");
            string ageStr = Console.ReadLine();
            byte age = Convert.ToByte(ageStr);

            // Obtains DUI info from applicant.
            Console.WriteLine("(2/3) True or False? Have you ever had a DUI?");
            string duiStr = Console.ReadLine();
            bool dui = Convert.ToBoolean(duiStr);

            // Obtains driving record info from applicant.
            Console.WriteLine("(3/3) How many speeding tickets do you have?");
            string numOfTicketsStr = Console.ReadLine();
            byte numOfTickets = Convert.ToByte(numOfTicketsStr);

            // Determines qualification of application.
            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && dui == false && numOfTickets <= 3);
            Console.ReadLine();

        }
    }
}
