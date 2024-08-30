using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Configration
{
    public class EmployeeEntityTypeConfiguration:IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(a => a.Name)
                   .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("FullName");


            builder.Property(x => x.Salary)
                .IsRequired()
            .HasDefaultValue(500);


            builder.Property(x =>x.Age)
                .HasComputedColumnSql("DATEDIFF(YEAR ,   [BirthDate] ,GETDATE())");

            //Configure one To Many
            builder
              .HasOne(a => a.Department)
             .WithMany(a => a.Employees);

            //Configure one To one
            builder
                .HasOne(a => a.Adress)
                .WithOne(a => a.Employee);

            //GlobaleQueryFilter
            //builder.HasQueryFilter(x => x.Is_Deleted == false);

        }
    }
}
