using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step313_OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            //employee.SayName();
            //Console.ReadLine();

            //IQuittable quit = new Employee();
            //quit.Quit();
            //Console.ReadLine();

            Employee e1 = new Employee(10);
            Employee e2 = new Employee(11);

            if (e1 == e2)
            {
                Console.WriteLine("The employees' IDs are the same.");
            }
            else if (e1 != e2)
            {
                Console.WriteLine("The employees' IDs are not the same.");
            }
            Console.ReadLine();
        }
    }
}
