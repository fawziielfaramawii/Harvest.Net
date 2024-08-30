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
    public class projectEntityTypeConfigration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder
                  .Property(a => a.Name)
                  .HasColumnName("Project Name")
                  .HasMaxLength(50);

            builder
                   .Property(a => a.Date)
                   //.HasDefaultValueSql("GETDATE()"); //sql Quary
                   //.HasDefaultValue(DateTime.Now);
                   .HasDefaultValue(new DateTime().Date);

            builder
                .HasQueryFilter(a => a.IsDeleted == false);

        }
    }
}
