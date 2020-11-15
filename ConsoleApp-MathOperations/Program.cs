using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
			//  Takes an input from the user, multiplies it by 50, then prints the result to the console.
			Console.WriteLine("Type first number:");
			string inputNum = Console.ReadLine();
			Console.WriteLine("Your number times 50 is: " + (Convert.ToInt32(inputNum) * 50));

			// Takes an input from the user, adds 25 to it, then prints the result to the console.
			Console.WriteLine("\nType in second number:");
			inputNum = Console.ReadLine();
			Console.WriteLine("Your number plus 25 is: " + (Convert.ToInt32(inputNum) + 25));

			//  Takes an input from the user, divides it by 12.5, then prints the result to the console.
			Console.WriteLine("\nType in third number:");
			inputNum = Console.ReadLine();
			Console.WriteLine("Your number divided by 12.5 is: " + (Convert.ToDouble(inputNum) / 12.5));

			//  Takes an input from the user, checks if it is greater than 50,
			//  then prints the true/false result to the console.
			Console.WriteLine("\nType in fourth number:");
			string numString = Console.ReadLine();
			int num4 = Convert.ToInt32(numString);
			bool trueOrFalse = num4 > 50;
			Console.WriteLine("Is your number greater than 50? " + trueOrFalse);

			//  Takes an input from the user, divides it by 7, 
			//  then prints the remainder to the console(tip: think % operator).
			Console.WriteLine("\nType in fifth number:");
			numString = Console.ReadLine();
			double num5 = (Convert.ToDouble(numString));
			Console.WriteLine("What is the Remainder? " + (num5 % 7));

			Console.ReadLine();
		}
	}
}
