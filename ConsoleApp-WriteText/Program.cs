using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp_WriteText
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asks the user for a number.
            Console.WriteLine("Hello, User! Please enter a number");
            int inputnum = Convert.ToInt32(Console.ReadLine());

            // Logs that number to a text file.
            string lineout = string.Format("The number is: " + inputnum + "\n");
            string fileName = "C:\\Users\\carol\\source\\repos\\Logs\\textLog.txt";
            using (StreamWriter writer = new StreamWriter(fileName, true))
            {
                writer.Write(lineout);
            }
            // Prints the text file back to the console.
            string text = "\n" + File.ReadAllText(fileName);
            Console.WriteLine("Contents of textLog.txt = {0}", text);

            Console.ReadLine();
        }
    }
}
