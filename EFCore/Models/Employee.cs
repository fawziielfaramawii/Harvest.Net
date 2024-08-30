using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsDeleted { get; set; }
        public Department Department { get; set; }
        public Address Address { get; set; }
        public ICollection<Project> Projects { get; set; }

    }
}
