using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore
{
    public class Project
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool Is_Deleted { get; set; }
    }
}
