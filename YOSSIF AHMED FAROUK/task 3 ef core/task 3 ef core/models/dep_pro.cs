using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_ef_core.models
{
    public class dep_pro
    {
        public int projectId { get; set; }
        public project project { get; set; }

        public int DepartmentClass1id { get; set; }
        public DepartmentClass1 department { get; set; }

        public DateTime date { get; set; }
    }
}
