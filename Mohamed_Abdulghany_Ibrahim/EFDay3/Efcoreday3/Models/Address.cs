using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcoreday3.Models
{
    public class Address
    {
        public int Street { get; set; }
        public int Gov { get; set; }
        [Key]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
