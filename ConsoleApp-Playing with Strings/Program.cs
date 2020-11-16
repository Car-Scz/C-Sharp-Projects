using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Playing_with_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Concatenates three strings.
            string part1 = "Horas non numero ";
            string part2 = "nisi serenas ";
            
            string sunDialMotto = (part1 + part2 + "(I count only the sunny hours)\n");
            Console.WriteLine(sunDialMotto);

            //  Converts a string to uppercase.
            string msg = "This is my C# Program Playing-with-Strings\n";
            string msgToUppers = msg.ToUpper();
            Console.WriteLine(msgToUppers);

            //  Creates a Stringbuilder and builds a paragraph of text, one sentence at a time.
            StringBuilder strbld = new StringBuilder();
            // Append to StringBuilder.
            for (int i = 0; i < 10; i++)
            {
                strbld.Append(i).Append(" ");
            }
            Console.WriteLine(strbld);

            Console.ReadLine();
        }
        
    }
}
