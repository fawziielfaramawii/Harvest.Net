using Efcoreday3.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Efcoreday3.Configrations
{
    public class EmployeeEntityTypeConfiguration : IEntityTypeConfiguration<Employee>
    {


        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(a => a.EmpId);


           builder.
                Property(a => a.Name).
                IsRequired().
                HasMaxLength(150).
                HasColumnName("FullName");
            builder.
              Property(a => a.Salary).
              IsRequired().
             HasDefaultValue(5000);

           


                          //computed column
            //builder.
            //  Property(a => a.Age)
            //  .HasComputedColumnSql("DATEDIFF(YEAR ,[DateOfBirth], GETDATE())");
          

        }
    }
}
