using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Structs
{
    // Create a struct called Number and give it the property "Amount" and have it be of data type decimal.
    public struct Number
    { 
        public decimal Amount; 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Number num1 = new Number();
            // create an object of data type Number and assign an amount to it.
            num1.Amount = 7.99m;
            // Print this amount to the console.
            Console.WriteLine($" The Number struct data type Amount has value {num1.Amount}. ");
            Console.ReadLine();
        }
    }
}
