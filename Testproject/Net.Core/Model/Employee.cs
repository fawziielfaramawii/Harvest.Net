using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Core.Model
{
   // [Table("Emps" , Schema="HR")]
    public class Employee // child / dependent
    {

        // Data Annotations
        [Key ,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        //[Required,MaxLength(150)]
        //[Column(TypeName ="FullName")]
        public string Name { get; set; }
        public double Salary { get; set; }
        public Department department { get; set; }  // refernence navigation prop
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }
        // [ForeignKey(nameof(Departid))]
        public int DepartmentId { get; set; }
        public Address address { get; set; }
        public bool isdeleted { get; set; }
    }
}
