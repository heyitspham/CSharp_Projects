using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step163_DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduction
            Console.WriteLine("The Tech Academy\nStudent Daily Report");
            
            // Questions for Daily Report
            Console.WriteLine("A. What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("B. What course are you on?");
            string courseTitle = Console.ReadLine();

            Console.WriteLine("C. What page number?");
            string coursePageAsString = Console.ReadLine();
            uint coursePageAsUint = Convert.ToUInt16(coursePageAsString);

            Console.WriteLine("D. Do you need help with anything? Please answer “true” or “false.”");
            string needsHelpAsString = Console.ReadLine();
            bool needsHelpAsBool = Convert.ToBoolean(needsHelpAsString);

            Console.WriteLine("E. Were there any positive experiences you’d like to share? Please give specifics.");
            string yourExperiences = Console.ReadLine();

            Console.WriteLine("F. Is there any other feedback you’d like to provide? Please be specific.");
            string yourFeedback = Console.ReadLine();

            Console.WriteLine("G. How many hours did you study today?");
            string studyHoursAsString = Console.ReadLine();
            uint studyHoursAsUint = Convert.ToUInt16(studyHoursAsString);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            Console.ReadLine();
        }
    }
}
