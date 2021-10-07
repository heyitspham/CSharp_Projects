using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step313_OperatorsAssignment
{
    class Employee : Person, IQuittable
    {
        public int Id { get; set; }

        public override void SayName()
        {
            Console.WriteLine($"Name: {firstName} {lastName}");
        }

        public void Quit()
        {
            Console.WriteLine("I'M OUT!!");
        }

        public Employee(int Id_01)
        {
            this.Id = Id_01;
        }

        public static bool operator ==(Employee e1, Employee e2)
        {
            return e1.Id == e2.Id;
        }

        public static bool operator !=(Employee e1, Employee e2)
        {
            return !(e1 == e2);
        }
    }
}

// 1. Overload the “==” operator so it checks if two Employee objects are equal by comparing their Id property.
