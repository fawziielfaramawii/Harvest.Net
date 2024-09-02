using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Core.Model
{
    public class Address
    {
        public int employeeid { get; set; } //relation one to one between add and emp
        public Employee employee { get; set; }
        [Key]
        public int street { get; set; }
        public int Gov { get; set; }
    }
}
