using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_Project.Model
{
    public class Address
    {
        public int Street { get; set; }
        public int Gov { get; set; }

        //relation one to one 
        [Key]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}
