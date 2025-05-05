using ABC.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Mapping
{
    public class DistributionKeyMapping : IEntityTypeConfiguration<DistributionKey>
    {
        public void Configure(EntityTypeBuilder<DistributionKey> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.DistributionKeyName).IsRequired().HasMaxLength(20);
            builder.Property(x => x.DistributionKeyRatio).IsRequired();
        }
    }
}
