using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Generics
{
    class Program
    {
        static void Main()
        {
            // Instantiate an Employee object
            Employee<string> employee = new Employee<string>();
            // created the new list of strings
            employee.Things = new List<string>() { "string1", "string2", "string3", "\n" };
            
            foreach (string item in employee.Things)
            {
                Console.WriteLine(item);
            }
            Employee<int> employee_int = new Employee<int>();
            employee_int.Things = new List<int>() { 100, 200, 300 };

            foreach (int item in employee_int.Things)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
