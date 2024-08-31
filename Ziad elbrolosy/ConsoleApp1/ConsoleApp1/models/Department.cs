using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
	public class Department
	{
		public int DepartmentId { get; set; }
		public string Name { get; set; }
		public bool IsDeleted { get; set; }

		//Default Value
		public DateTime Date { get; set; } = DateTime.Now;
		// Relations 
		public ICollection<Employee> Employee { get; set; }
		public ICollection<Project> projects { get; set; }

	}
}
