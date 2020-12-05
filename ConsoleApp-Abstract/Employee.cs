using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Abstract
{
    // inherits from Person class
    class Employee : Person
    {
        // properties of this class
        public int Id { get; set; }

        // Implement the SayName() method inside of the Employee class.
        public override void SayName() 
        {
            Console.WriteLine("\nName: " + firstName + " " + lastName);
        }
    }
}
