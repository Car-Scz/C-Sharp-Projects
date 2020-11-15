using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Insurance_Approval_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Approval Insurance Questionnaire");
            //  first question
            Console.WriteLine("\nWhat is your age?");
            string strAge = Console.ReadLine();
            int Age = Convert.ToUInt16(strAge);
            //  second question
            Console.WriteLine("Have you ever had a DUI (please respond with \"true\" or \"false\" ?");
            string strDUI = Console.ReadLine();
            bool isTrue = Convert.ToBoolean(strDUI);
            // thrid question
            Console.WriteLine("How many speeding tickets do you have?");
            string strSpeedTkts = Console.ReadLine();
            int speedTkts = Convert.ToUInt16(strSpeedTkts);

            // calcuate whether this person meets the criteria of
            // must be over 15 years, no DUIs, and no more than 3 speeding tickets
            bool decision = (Age > 15) && (isTrue == false) && (speedTkts <= 3);
            Console.WriteLine("\nQualified?");
            Console.WriteLine(decision);

            Console.ReadLine();
        }
    }
}
