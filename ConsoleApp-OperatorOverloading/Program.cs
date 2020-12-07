using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_OperatorOverloading
{
    class Program
    {
        static void Main()
        {
            // Instantiate an Employee object
            Employee employee1 = new Employee();
            // Initialize the first Employee object
            employee1.Id = 1;
            employee1.firstName = "Sample";
            employee1.lastName = "Student";
            // Instantiate a second Employee object
            Employee employee2 = new Employee();
            // Initialize the second Employee object
            employee2.Id = 2;
            employee2.firstName = "Another";
            employee2.lastName = "Student";

            Console.WriteLine("I am here.");
            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1 != employee2);

            // Calling the superclass method on the Employee object.
            //employee1.SayName();
            //employee1.Quit();
            Console.ReadLine();
        }
    }
}
