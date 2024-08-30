using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
	public class Employee
	{
		public int EmployeeId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public DateTime DateOfBirth { get; set; }
		public int Age { get; set; }
		public bool IsDeleted { get; set; }
		// Relations 
		public Address Address { get; set; }
		public Department Department { get; set; }
	}
}
