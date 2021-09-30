using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step337_LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. In the Main() method, create a list of at least 10 employees. Each employee should have a first and last name, as well as an Id. At least two employees should have the first name “Joe”.
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee(){ firstName="Abe", lastName="Axel", Id=10},
                new Employee(){ firstName="Bob", lastName="Beau", Id=11},
                new Employee(){ firstName="Cal", lastName="Cole", Id=12},
                new Employee(){ firstName="Dax", lastName="Dash", Id=13},
                new Employee(){ firstName="Ean", lastName="Enzo", Id=14},
                new Employee(){ firstName="Fin", lastName="Finn", Id=15},
                new Employee(){ firstName="Geo", lastName="Gage", Id=16},
                new Employee(){ firstName="Huy", lastName="Hugo", Id=17},
                new Employee(){ firstName="Ida", lastName="Ivan", Id=18},
                new Employee(){ firstName="Joe", lastName="Joey", Id=19},
                new Employee(){ firstName="Joe", lastName="Jude", Id=20}
            };

            Console.WriteLine("Hi. For which name would you like to search in the list?");
            string searchedName = Console.ReadLine();

            List<Employee> listOfSearchedName = new List<Employee>();

            foreach (Employee employee in employeeList)
            {
                if(employee.firstName == searchedName)
                {
                    listOfSearchedName.Add(employee);
                    Console.WriteLine($"{employee.firstName} {employee.lastName}, ID={employee.Id}");
                }
            }
            Console.WriteLine($"There is/are {listOfSearchedName.Count} {searchedName}'s in the list. Shown above.");

            Console.ReadLine();
        }
    }
}

// 2. Using a foreach loop, create a new list of all employees with the first name “Joe”.
// 3. Perform the same action again, but this time with a lambda expression.
// 4. Using a lambda expression, make a list of all employees with an Id number greater than 5.
