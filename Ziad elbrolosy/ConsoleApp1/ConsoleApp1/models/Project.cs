using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
	public class Project
	{
		public int ProjectId { get; set; }
		public string Name { get; set; }
		public bool IsDeleted { get; set; }
		// Relations 
		public ICollection<Department> Departments { get; set; }

	}
}
