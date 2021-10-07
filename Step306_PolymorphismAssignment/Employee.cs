using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step306_PolymorphismAssignment
{
    // 2. Have your Employee class from the previous drill inherit that interface and
    class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }

        // 2a. implement the Quit() method in any way you choose.
        public void Quit()
        {
            Console.WriteLine("I'M OUT!!");
        }
    }
}
