using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayingWithMethods
{
    class Program
    {
        static void Main()
        {
            // In the Main() method, instantiate that class.
            Class1 myMethods = new Class1();

            // Have the user enter a number.
            Console.WriteLine("Input an integer:");
            int number = Convert.ToInt32(Console.ReadLine());
            // Call the method on that number and display the output to the screen which should
            // be the entered number divided by two.
            myMethods.SumValues(number);

            // Create a method with output parameters.
            int o = 100;  // local variable defn
            int p = 205;
            // The before image of the output parameters
            Console.WriteLine("\nBefore method call, value of o/p : {0} and {1}", o, p);
            // Calling the function with the output parameters 
            myMethods.GetValue(out o, out p);
            // The after image of the output parameters
            Console.WriteLine("After method call, value of o/p : {0} and {1}", o, p);

            // Overloading methods in Class1
            decimal a = 24;
            int retVal = myMethods.MyFunc(a, 23);
            Console.WriteLine("\nMyFunc(decimal): The return value is {0}", retVal);
            string c = "18";
            retVal = myMethods.MyFunc(c, 7);
            Console.WriteLine("MyFunc(string): The return value is {0}", retVal);
            
            // Accessing the static data members of Class2
            Console.WriteLine("\nThis method is declared a : {0} ", Class2.my_item);
            Console.WriteLine("The course I'm taking now is : {0} ", Class2.my_course);
            Console.WriteLine("My number is : {0} ", Class2.my_number);
            
            Console.ReadLine();
        }
    }
}
