using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Core.Model
{
    public class Project
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }
        public ICollection<Department> departments { get; set; }
    }
}
