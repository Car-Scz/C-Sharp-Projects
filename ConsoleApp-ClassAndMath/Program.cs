using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ClassAndMath
{
    class Program
    {
        static void Main()
        {
            // Instantiation #1
            DoMath classObj = new DoMath();
            int a = 12;
            classObj.MathFunc(a, 23);
            int retVal = classObj.ResultX;
            Console.WriteLine("\nMatchFunc(int): The return value is {0}", retVal);

            // Instantiation #2
            DoMath classObj2 = new DoMath();
            decimal b = 24;
            classObj2.MathFunc(b, 5);
            retVal = classObj2.ResultX;
            Console.WriteLine("\nMatchFunc(decimal): The return value is {0}", retVal);

            // Instantiation #3
            DoMath classObj3 = new DoMath();
            string c = "18";
            classObj3.MathFunc(c, 7);
            retVal = classObj3.ResultX;
            Console.WriteLine("\nMatchFunc(string): The return value is {0}", retVal);

            // Wait for user to acknowledge.
            Console.WriteLine("\nPress Enter to exit. . .");
            Console.ReadLine();
        }
    }
}
