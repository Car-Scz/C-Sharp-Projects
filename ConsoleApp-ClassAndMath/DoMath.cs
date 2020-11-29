using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ClassAndMath
{
    class DoMath
    {
        //public int result { get; set; }
        // this function adds the two values and saves in result  
        public int MathFunc(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        // this function subtracts the the 2nd value from the 1st vavlue and saves in result  
        public int MathFunc(decimal num1, int num2)
        {
            int result = Convert.ToInt32(num1) - num2;
            return result;
        }
        // this function multiplies the two numbers saves in result  
        public int MathFunc(string num1, int num2)
        {
            int result = Convert.ToInt32(num1) * num2;
            return result;
        }
    }
}
       