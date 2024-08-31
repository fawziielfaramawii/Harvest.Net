using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_ef_core.models
{
    public class employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime brithdate { get; set; }
        public int age { get; set; }

        public bool isdeleted { get; set; }
        public addrsses addrsse { get; set; }
        public double salary { get; set; }
        public DepartmentClass1 Department { get; set; }
    }
}
