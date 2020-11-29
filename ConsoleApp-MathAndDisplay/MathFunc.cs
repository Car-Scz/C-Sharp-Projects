using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_MathAndDisplay
{
    class MathFunc
    {
        // 
        public void AddFunc(int num1, int num2)
        {
            int x = num1 * num2;
            Console.WriteLine("\nThis is the second parameter passed to this method: " + num2);
        }
    }
}