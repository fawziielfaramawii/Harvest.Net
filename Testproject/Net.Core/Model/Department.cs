using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Core.Model
{
    public class Department  // parent or principle 
    {
        public int id { get; set; } // principle key
        public string name { get; set; }
        public string location { get; set; }
        public List<Employee> employees { get; set; }  // collection navigation prop
        public ICollection<Project> projects { get; set; }
    }
}
