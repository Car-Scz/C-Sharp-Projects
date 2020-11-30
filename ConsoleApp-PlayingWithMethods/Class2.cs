using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayingWithMethods
{
    static class Class2
    {
        // Static data members of static class
        public static string my_item = "static method";
        public static string my_course = "C# & .NET FRAMEWORK COURSE";
        public static int my_number = 84;

        // Static method of the class
        public static void Details()
        {
            Console.WriteLine("The details listed in this class are: ");
        }
    }
}
