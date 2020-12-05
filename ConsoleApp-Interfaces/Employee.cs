using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Interfaces
{
    // inherits from Person class
    class Employee : Person, IQuittable
    {
        // properties of this class
        public int Id { get; set; }

        // Implement the SayName() method inside of the Employee class.
        public override void SayName()
        {
            Console.WriteLine("\nName: " + firstName + " " + lastName);
        }
        public void Quit()
        {
            // The body of Quit() is provided here
            Console.WriteLine("I am in the Quit method of the class Employee.  So \"I QUIT!\" ");
        }
    }
}
