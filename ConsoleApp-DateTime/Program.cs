using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints the current date and time to the console.
            Console.WriteLine("\nCurrent date/time is " + Convert.ToString(DateTime.Now));

            // Asks the user for a number.
            Console.Write("\nEnter a number: ");
            int inputnum = Convert.ToInt32(Console.ReadLine());

            // Prints to the console the exact time it will be in X hours, 
            // X being the number the user entered in step 2.
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("\nIt will be {0} in {1} hours.", currentTime.AddHours(inputnum), inputnum);

            Console.ReadLine();
        }
    }
}
