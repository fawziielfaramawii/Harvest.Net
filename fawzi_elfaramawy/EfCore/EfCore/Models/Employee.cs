using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore
{

//    [Table("Emps" , Schema ="dbo")]
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        public bool Is_Deleted{ get; set; }
        public DateTime BirthDate { get; set; }
        public  Adress Adress { get; set; }
        public int DepartmentId { get; set; }
        public  Department Department { get; set; }


    }
}
