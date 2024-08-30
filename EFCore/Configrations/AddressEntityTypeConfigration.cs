using EFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Configrations
{
    public class AddressEntityTypeConfigration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.
                 HasKey(a => new { a.Zone, a.street });

            builder
                .HasQueryFilter(a => a.IsDeleted == false);
        }
    }
}
