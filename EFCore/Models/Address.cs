using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class Address
    {
        public int street { get; set; }
        public string city { get; set; }
        public int Zone { get; set; }
       public bool IsDeleted { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
