using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperatorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            // Obtains hourly rate for person-1 and converts the string to a float.
            Console.WriteLine("Person 1");
            Console.WriteLine("a. What is your hourly rate?");
            string p1HourlyRateStr = Console.ReadLine();
            float p1HourlyRate = Convert.ToInt16(p1HourlyRateStr);

            // Obtains hours worked per week for person-1 and converts the string to a float.
            Console.WriteLine("b. How many hours do you work per week?");
            string p1HoursPerWeekStr = Console.ReadLine();
            float p1HoursPerWeek = Convert.ToInt16(p1HoursPerWeekStr);

            // Obtains hourly rate for person-2 and converts the string to a float.
            Console.WriteLine("Person 2");
            Console.WriteLine("a. What is your hourly rate?");
            string p2HourlyRateStr = Console.ReadLine();
            float p2HourlyRate = Convert.ToInt16(p2HourlyRateStr);

            // Obtains hours worked per week for person-2 and converts the string to a float.
            Console.WriteLine("b. How many hours do you work per week?");
            string p2HoursPerWeekStr = Console.ReadLine();
            float p2HoursPerWeek = Convert.ToInt16(p2HoursPerWeekStr);

            // Calculates salary for person-1
            Console.WriteLine("Annual salary of Person 1:");
            float p1Salary = p1HourlyRate * p1HoursPerWeek * 52.0f;
            Console.WriteLine(p1Salary);

            // Calculates salary for person-2
            Console.WriteLine("Annual salary of Person 2:");
            float p2Salary = p2HourlyRate * p2HoursPerWeek * 52.0f;
            Console.WriteLine(p2Salary);

            // Compares the salary of person-1 to person-2
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(p1Salary > p2Salary);
            Console.ReadLine();

        }
    }
}
