using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore
{
    public class Adress
    {
        public int street { get; set; }
        public int Gov { get; set; }
        [Key]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
