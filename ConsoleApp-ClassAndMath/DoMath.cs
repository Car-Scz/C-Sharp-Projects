using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ClassAndMath
{
    class DoMath
    {
        private int result;
        public int ResultX
        {
            get
            {
                return result;
            }
            set
            {
                result = 0;
            }
        }
        // this function adds the two values and saves in result  
        public void MathFunc(int num1, int num2)
        {
            result = num1 + num2;
        }
        // this function subtracts the the 2nd value from the 1st vavlue and saves in result  
        public void MathFunc(decimal num1, int num2)
        {
            result = Convert.ToInt32(num1) - num2;
        }
        // this function multiplies the two numbers saves in result  
        public void MathFunc(string num1, int num2)
        {
            result = Convert.ToInt32(num1) * num2;
        }
    }
}
       