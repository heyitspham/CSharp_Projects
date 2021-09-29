using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step302_AbstractClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Inside the Main() method, instantiate an Employee object with firstName “Sample” and lastName “Student”.
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student" };
            
            // 5a. Call the SayName() method on the object.
            employee.SayName();
            Console.ReadLine();
        }
    }
}
