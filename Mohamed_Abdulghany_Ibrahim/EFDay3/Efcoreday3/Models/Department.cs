using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcoreday3.Models
{
    public class Department//parent Entity,princible entity
    {
        public int Id { get; set; }//princible key
        public string Name { get; set; }
        public string Location { get; set; }
        public ICollection <Employee> Employees { get; set; }//collection navigation property
        public ICollection<project> projects { get; set; }
    }
}
