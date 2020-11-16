using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_BooleanComparisonsLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // the while loop
            Console.WriteLine("Start with the \"while\" Loop...\n");
            bool keepGoing = true;
            int i = 0;

            while (keepGoing)
            {
                Console.WriteLine("This is line " + i);
                i ++;

                if (i > 10)
                {
                    keepGoing = false;
                    Console.WriteLine("\nThe \"while\" loop is done.\n");
                }
            }

            //  do-while Loop
            Console.WriteLine("\nNow the \"do-while\" Loop...\n");
            keepGoing = true;
            i = 0;

            do
            {
                i++;
                Console.WriteLine("This is line " + i);
                if (i > 9)
                {
                    keepGoing = false;
                }
            }
            while (keepGoing);
            {
                Console.WriteLine("\nThe \"do-while\" loop is done.");
            }

            Console.ReadLine();
        }
    }
}
