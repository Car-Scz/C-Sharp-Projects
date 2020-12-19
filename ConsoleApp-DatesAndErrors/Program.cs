using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DatesAndErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            var today = DateTime.Today;

            // Exceptions must be handled using “try/catch.”
            try
            {
                // Ask the user for their age.
                Console.Write("\nWhat is your age?\t");
                string inputYear = Console.ReadLine();
                age = int.Parse(inputYear);
                if (age > 0) 
                {
                    int birthYear = today.Year - age;
                    // Display the year the user was born.
                    Console.WriteLine("\nYou were born in the year of {0}!", birthYear);
                } else
                {
                    // Display appropriate error messages if the user enters zero or negative numbers.
                    Console.WriteLine("\nYear cannot be zero or negative!");
                }
            }
            catch (Exception)
            {
                // Display a general message if an exception was caused by anything else.
                Console.WriteLine("\nThe age you entered could not be processed.");
            }

            Console.ReadLine();
        }
    }
}
