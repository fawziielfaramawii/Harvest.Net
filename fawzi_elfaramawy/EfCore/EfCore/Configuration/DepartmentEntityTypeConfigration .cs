using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Configration
{
    public class DepartmentEntityTypeConfiguration:IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            //DataSeeding - Datainitializer
            List<Department> departments = new List<Department>()
            {
                new Department(){Id = 2, Name="IT",Location="Mansoura"} ,
                new Department(){Id = 3,Name="IS",Location="Menoufia"} ,
                new Department(){Id = 4,Name="HR",Location="Assuit"} ,

            };
             builder.HasData(departments);
            builder.HasQueryFilter(x => x.Is_Deleted == false);
           
        }
    }
}
