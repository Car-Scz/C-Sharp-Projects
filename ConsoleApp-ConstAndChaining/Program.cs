using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ConstAndChaining
{
    public class Employee
    {
        public Employee() : this(string.Empty, string.Empty, string.Empty)
        {
            Console.WriteLine("Employee() constructor called");
        }
        public Employee(string Name, string EmpId) : this(Name, EmpId, string.Empty)
        {
            Console.WriteLine("Employee(Name,EmpId) constructor called");
        }
        public Employee(string Name, string EmpId, string Department)
        {
            Console.WriteLine("\nEmployee(Name,EmpId,Department) constructor called");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a const variable.
            const string sentence = "This is a string constant";

            // Create a variable using the keyword "var.”
            var data = new int[] { 23, 34, 455, 65 };

            // Chain two constructors together.
            Employee emp1 = new Employee("Marc", "32", "Accounting");
            Employee emp2 = new Employee();
            Employee emp3 = new Employee("Julio", "55");
            Console.ReadLine();
        }
    }
}
