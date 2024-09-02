using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Core.Model
{
    public class deptproject
    {
        public int departmentid { get; set; }
        public Department department { get; set; }

        public Project Project { get; set; }
        public int proid { get; set; }
        public DateTime date { get; set; }
        public string location { get; set; }
    }
}
