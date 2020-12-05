using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object
            Employee employee = new Employee();
            // Initialize the  Employee object
            employee.firstName = "Sample";
            employee.lastName = "Student";

            // Calling the superclass method on the Employee object.
            employee.SayName();
            employee.Quit();

            Console.ReadLine();
        }
    }
}
