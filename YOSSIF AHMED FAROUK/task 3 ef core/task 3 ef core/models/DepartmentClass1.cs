using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_ef_core.models
{
    public class DepartmentClass1
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string location { get; set; }
        public ICollection<employee> employees { get; set; }
        public ICollection<project> projects { get; set; }

    }
}
