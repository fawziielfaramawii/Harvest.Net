using EFC_Project.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace EFC_Project.Configurations
{
    public class EmployeeEntityTypeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {

            builder.HasKey(a => a.EmpId);




            builder.Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("Full Name");

            builder.Property(a => a.Salary)
                .IsRequired()
                .HasDefaultValue(5000);



            builder
         .Property(e => e.Age)
         .HasComputedColumnSql("DATEDIFF(year, [DateOfBirth], GETDATE())");

        }
    } 
}
