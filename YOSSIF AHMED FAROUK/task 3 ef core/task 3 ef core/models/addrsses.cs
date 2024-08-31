using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_ef_core.models
{
    public class addrsses
    {
        public string street { get; set; }
        public string gov { get; set; }
        [Key]
        public int employeeid { get; set; }
        public employee employee { get; set; }
    }
}
