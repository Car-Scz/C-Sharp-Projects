using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingProject_ShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.WriteLine("\nPlease enter the package weight:");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());
            // package to heavy?
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("\nPlease enter the package width:");
                int pkgWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package height:");
                int pkgHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                int pkgLength = Convert.ToInt32(Console.ReadLine());
                // Check dimensions
                if (pkgWidth + pkgHeight + pkgLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                }
                else
                {
                    // Print out the quote
                    decimal pkgQuote = ((pkgWidth * pkgHeight * pkgLength) * pkgWeight) / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: " +
                        (string.Format("{0:C}", pkgQuote)));
                    Console.WriteLine("Thank you!");
                }
            }
            Console.ReadLine();
        }

    }
}
