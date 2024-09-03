using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Efcoreday3.Models
{
   // [Table("Emps",Schema ="Hr")]
    public class Employee//child entity,dependent entity
    {
       // public int Id { get; set; }
       //data anotaions
      //  [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      
        public int EmpId { get; set; }
       // [Required,MaxLength(150)]
      //  [Column(TypeName ="fullName")]
        //[MaxLength(255)]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
      
        public double Salary { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; } //reference navigation property
        public bool Isdeleted { get; set; }
        public Address Address { get; set; }
    }
}
