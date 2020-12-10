using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Generics
{
    // inherits from Person class
    class Employee<T> : Person
    {
        // properties of this class
        public int Id { get; set; }
        public List<T> Things { get; set; }
    }
}
