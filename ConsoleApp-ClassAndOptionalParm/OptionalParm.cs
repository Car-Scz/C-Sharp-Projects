using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ClassAndOptionalParm
{
    // Create a class and then...
    class OptionalParm
    {
        // Create a method that performs a math operation
        // The method receives two parameter integers and returns an integer result.
        // Parm 1 is required and parm 2 is optional.
        public int MathFunc(int num1, int num2=0)
        {
            int result = num1 + num2;
            return result;
        }
    }
}
