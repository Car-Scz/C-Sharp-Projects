using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_PlayingWithMethods
{
    class Class1
    {
        // In the created class, Class1, a void method called sumValues outputs an integer that .
        // is divided by 2.
        public int Result { get; set; }

        public void SumValues(int num1)
        {
            int result;
            result = num1 / 2;
            Console.WriteLine("The passed value " + num1 + " divided by 2 equals " + result);
            Console.WriteLine();
        }
        //  the next 2 methods are overloaded
        public int MyFunc(decimal num1, int num2)
        {
            int result = Convert.ToInt32(num1) + num2;
            return result;
        }
        // this function subtracts the the 2nd value from the 1st vavlue and saves in result  
        public int MyFunc(string num1, int num2)
        {
            int result = Convert.ToInt32(num1) * num2;
            return result;
        }
        //  method with 2 out parameters
        public void GetValue(out int x, out int y)
        {
            int num1 = 5;
            x = num1;
            int num2 = 29;
            y = num2;
        }
    }
}
