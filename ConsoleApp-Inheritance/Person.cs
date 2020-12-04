using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Inheritance
{
    public class Person
    {
        // properties of this class
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        // void method with no parameters which prints the person's name
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
