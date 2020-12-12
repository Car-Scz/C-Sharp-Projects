using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ListsAndLambdas
{
	class Program
	{
		static void Main()
		{
			// In the Main() method, create a list of at least 10 employees.
			// Each employee should have a first and last name, as well as an Id.
			// At least two employees should have the first name "Joe".
			List<Employee> emplist = new List<Employee>();
			
			emplist.Add(new Employee(1, "Joe", "Blow"));
			emplist.Add(new Employee(2, "Steve", "Hanes"));
			emplist.Add(new Employee(3, "Mary", "Jane"));
			emplist.Add(new Employee(4, "Phillip", "Locke"));
			emplist.Add(new Employee(5, "Joe", "Ryan"));
			emplist.Add(new Employee(6, "Bill", "Tanner"));
			emplist.Add(new Employee(7, "Steve", "Jordan"));
			emplist.Add(new Employee(8, "Pam", "North"));
			emplist.Add(new Employee(9, "Joe", "Helium"));
			emplist.Add(new Employee(10, "Pat", "Little"));

			// Using a foreach loop, create a new list of all employees with the first name "Joe".
			Console.WriteLine("\n-----------------------------------------------------------------------------");
			Console.WriteLine("Retrieving all employees with the first name of \"Joe\" in a foreach loop.\n");
			foreach (var item in emplist)
			{
				if (item.FirstName == "Joe")
				{
					Console.WriteLine("Emp Id: {0}\tEmp Name: {1} {2}",
						item.EmpId, item.FirstName, item.LastName);
				}
			}
			// Perform the same action again, but this time with a lambda expression.
			Console.WriteLine("\n-----------------------------------------------------------------------------");
			Console.WriteLine("Retrieving all employees with the first name of \"Joe\" using a lambda expression\n");
			foreach (Employee emps in emplist.FindAll(x => x.FirstName == "Joe"))
			{
				Console.WriteLine("Emp Id: {0}\tEmp Name: {1} {2}",
					emps.EmpId, emps.FirstName, emps.LastName);
			}
			// Using a lambda expression, make a list of all employees with an Id number greater than 5.
			Console.WriteLine("\n-----------------------------------------------------------------------------");
			Console.WriteLine("Retrieving all employees with the IDs > 5 using a lambda expression\n");
			foreach (Employee emps in emplist.FindAll(x => x.EmpId > 5))
			{
				Console.WriteLine("Emp Id: {0}\tEmp Name: {1} {2}",
					emps.EmpId, emps.FirstName, emps.LastName);
			}
			Console.ReadLine();
		}
	}
}
