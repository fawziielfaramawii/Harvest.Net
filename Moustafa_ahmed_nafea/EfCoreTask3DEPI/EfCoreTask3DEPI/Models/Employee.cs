using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTask3DEPI.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age { get; set; }

        public bool IsDeleted { get; set; }

        public Address Address { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
