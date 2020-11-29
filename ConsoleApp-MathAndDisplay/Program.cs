using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MathAndDisplay
{
    class Program
    {
        static void Main()
        {
            // Create an instance of class MathFunc 
            MathFunc classobj = new MathFunc(); 
            // sending 2 unnamed parameters to the method
            classobj.AddFunc(15,25);

            // sending 2 named parameters to the method
            classobj.AddFunc(num1: 15, num2: 9);

            // Wait for user to acknowledge the results.
            Console.WriteLine("\nPress Enter to terminate. . .");
            Console.ReadLine();
        }
    }
}
