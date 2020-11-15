using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Print heading of report
            Console.WriteLine("Anonymous Income Comparison Program");

            //  Get Person 1's hourly rate and hours worked
            Console.WriteLine("\nPerson 1");
            Console.WriteLine("Hourly rate? ");
            string numString = Console.ReadLine();      // hourly rate
            decimal hrlyRate = Convert.ToDecimal(numString);  // convert to decimal
           
            Console.WriteLine("\nHours per week worked? ");
            numString = Console.ReadLine();       
            int hrsWorked = Convert.ToInt32(numString);
            decimal annualSalary1 = (hrlyRate * hrsWorked) * 52;   // calcualate annual salary

            //  Get Person 2's hourly rate and hours worked
            Console.WriteLine("\nPerson 2");
            Console.WriteLine("Hourly rate? ");
            numString = Console.ReadLine();      // hourly rate
            hrlyRate = Convert.ToDecimal(numString);  // convert to decimal

            Console.WriteLine("\nHours per week worked? ");
            numString = Console.ReadLine();
            hrsWorked = Convert.ToInt32(numString);
            decimal annualSalary2 = (hrlyRate * hrsWorked) * 52;   // calcualate annual salary


            //  Compare Annual salaries of Person 1 and 2
            Console.WriteLine("\nAnnual salary of Person 1:");
            Console.WriteLine(annualSalary1);
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine(annualSalary2);
            bool trueOrFalse = annualSalary1 > annualSalary2;
            Console.WriteLine("\nDoes Person 1 make more money than Person 2?");
            Console.WriteLine(trueOrFalse);

            Console.ReadLine();

        }
    }
}
