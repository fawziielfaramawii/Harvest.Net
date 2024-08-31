using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_ef_core.models
{
    public class project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime datatime { get; set; }

        public ICollection<DepartmentClass1> departments { get; set; }
    }
}
