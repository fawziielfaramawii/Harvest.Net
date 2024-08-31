using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task_3_ef_core.models;

namespace task_3_ef_core.config
{
    public class employeeentitytypeconfigration: IEntityTypeConfiguration<models.employee>
    {
        

        public void Configure(EntityTypeBuilder<models.employee> builder)
        {
            builder.Property(a => a.salary)
                .HasDefaultValue(5000);


            builder.Property(a => a.age)
                .HasComputedColumnSql("DATEDIFF(YEAR , [brithdate] , GETDATE() )");


            builder
                .HasQueryFilter(a=> a.isdeleted == false);
        }

        
    }
}
