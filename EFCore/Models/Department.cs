using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class Department
    {

        public int Id { get; set; }//principl Key
        public string Name { get; set; }
        public string location { get; set; }
        public bool IsDeleted { get; set; }
        public List<Employee> Employees { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}
