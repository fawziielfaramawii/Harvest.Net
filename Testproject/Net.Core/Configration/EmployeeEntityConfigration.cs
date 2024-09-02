using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Net.Core.Model;

namespace Net.Core.confiration
{
    public class BlogEntityTypeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(a => a.id);
            builder
               .Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("FullNmae");
               

            // builder.Property(a => a.DateOfBirth)
            builder.Property(a => a.Age)
                .HasComputedColumnSql("DATEDIFF(YEAR ,[DateOfBirth],GETDATE())");

        }
    }
}
