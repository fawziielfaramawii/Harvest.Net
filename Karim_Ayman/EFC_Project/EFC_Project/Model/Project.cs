using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_Project.Model
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }

       public ICollection<Department>departments { get; set; }
    }
}
