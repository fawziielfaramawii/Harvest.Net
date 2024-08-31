using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
	public class Address
	{
		public int AddressId { get; set; }
		public string Street { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		// Relations 
		public int EmployeeId { get; set; }
		public Employee Employee { get; set; }
	}
}
