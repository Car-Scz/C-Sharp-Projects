using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Interfaces
{
    public abstract class Person
    {
        // properties of this abstract class
        public string firstName { get; set; }
        public string lastName { get; set; }

        // void method with no parameters which prints the person's name
        public abstract void SayName();
    }
}
