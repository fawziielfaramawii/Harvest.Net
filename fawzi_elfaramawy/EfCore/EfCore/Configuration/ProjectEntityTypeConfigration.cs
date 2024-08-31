using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.Configration
{
    public class ProjectEntityTypeConfiguration:IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {

            builder.Property(x => x.Date)
                .HasDefaultValue(new DateTime().Date);

            builder.HasQueryFilter(x => x.Is_Deleted == false);

        }
    }
}
