using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ListsAndLambdas
{
    class Employee
    {
		public int EmpId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
        public Employee(int empid, string fname, string lname)
        {
            EmpId = empid;
            FirstName = fname;
            LastName = lname;
        }
    }
}
