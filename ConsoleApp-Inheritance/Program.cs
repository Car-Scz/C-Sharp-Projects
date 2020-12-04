using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Inheritance
{
    class Program
    {
        static void Main()
        {
            // Instantiate an Employee object
            Employee employee = new Employee();
            // Initialize the  Employee object
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            // Calling the superclass method on the Employee object.
            employee.SayName();
            Console.ReadLine();
        }
    }
}
