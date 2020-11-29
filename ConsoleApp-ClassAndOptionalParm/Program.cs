using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ClassAndOptionalParm
{
    class Program
    {
        static void Main()
        {
            // Instantiate the class.
            OptionalParm classObj = new OptionalParm();

            // Ask the user to input two numbers. The first number is required
            Console.WriteLine("Please enter the first integer: ");
            int requiredInt = Convert.ToInt32(Console.ReadLine());

            // Thhe second number is not required
            Console.WriteLine("Please enter the second integer (this integer is not required): ");
            // get input value, if any
            string str = Console.ReadLine();
            // Test for null or empty
            bool isTrueOrFalse;
            isTrueOrFalse = str == null || str == string.Empty;

            // optional parm was not entered
            int retVal;
            if (isTrueOrFalse == true) 
            {
                // Call the method in the class passing in the required parameter
                retVal = classObj.MathFunc(requiredInt);
            }
            else
            {
                // Call the method in the class passing both parameters
                int optionalInt = Convert.ToInt32(str);
                retVal = classObj.MathFunc(requiredInt, optionalInt);
            }

            // Display the returned value
            Console.WriteLine("\nMatchFunc returned the value of {0}", retVal);

            // Wait for user to acknowledge.
            Console.WriteLine("\nPress Enter to exit. . .");
            Console.ReadLine();
        }
    }
}
