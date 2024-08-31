using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_Project.Model
{
    public class Employee //child entity Or DependentEntity 
    {
        public int EmpId { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        //btt3ml tlqa2y with navigation properity
        //for adding values 
        public bool IsDeleted { get; set; }
        public int DepartmentId { get; set; }
        //relation 1 to many 
        public Department Department { get; set; } //Refrence Navigation Properity 
        public Address Address { get; set; }

    }
}
