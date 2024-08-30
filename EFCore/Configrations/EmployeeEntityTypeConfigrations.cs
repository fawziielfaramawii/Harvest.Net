using EFCore.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Configrations
{
    public class EmployeeEntityTypeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            
            builder.Property(a => a.Name)
                   .IsRequired()
                   .HasMaxLength(50)
                   .HasColumnType("varchar(30)")
                   .HasColumnName("Employee name");

            builder.Property(a => a.Salary)
                   // .IsRequired()
                   .HasDefaultValue(5000)
                   .HasColumnName("Employee Salary");

            builder.Property(a => a.Age)
                .HasComputedColumnSql("DATEDIFF(YEAR ,GETDATE(),[DateOfBirth])");//wrie Sql Query 

            builder
                 .HasQueryFilter(a => a.IsDeleted == false);
        }
    }
}
