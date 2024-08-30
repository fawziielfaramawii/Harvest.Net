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
    public class DepartmentEntityTypeConfigration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(a => a.Name)
               .HasMaxLength(50)
               .HasColumnName("Department name");

            builder
                .HasQueryFilter(a => a.IsDeleted == false);



        }
    }
}

