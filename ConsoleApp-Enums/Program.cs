using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Enums
{
    class Program
    {
        // Create an enum for the days of the week.
        public enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
            // Wrap the user input code in a try/catch block and ...
            try
            {
                // Prompt the user to enter the current day of the week.
                Console.WriteLine("Hello! A week has 7 days! What day of this week is it?");
                // Assign the value to a variable of that enum data type you just created.
                var inputDay = Console.ReadLine();
                // parsing enums
                DaysOfWeek dayEntered = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), inputDay);
                Console.WriteLine("\nThe day you entered was {0}", dayEntered);
            }
            catch (Exception)
            {
                // Have it send an error message to the console if an error occurs.
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadKey();
        }
    }
}
