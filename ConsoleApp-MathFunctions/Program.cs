using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        /* local variable definition */
        int a = 200;
        int ret;

        // Get user input
        Console.Write("Please pick a number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        // Instantiate an object of the class
        ProcessData proc = new ProcessData();

        // Printing the start of the "report"...
        Console.WriteLine("\n==============================");
        
        // Calling the addition method
        ret = proc.addNbr(a, b);
        Console.WriteLine("\nValues " + a + " plus " + b + " is : {0}", ret);
        
        // Calling the subtraction  method
        ret = proc.subNbr(a, b);
        Console.WriteLine("\nValues " + a + " subtract " + b + " is : {0}", ret);
        
        // Calling the multiplication  method
        ret = proc.multNbr(a, b);
        Console.WriteLine("\nValues " + a + " multiply " + b + " is : {0}", ret);
        
        // Printing the rest of the "report"...
        Console.WriteLine("\n==============================");

        Console.WriteLine("Press ENTER to continue. . .");
        Console.ReadLine();
    }
}    