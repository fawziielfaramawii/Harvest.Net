using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_Project.Model
{
    public class Department //parent OR Prenciple
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        //relation 1 to many 
        public ICollection<Employee> Employees { get; set; } //Collection Navigation Properity 
        public ICollection<Project> Projects { get; set; }
    }
}
