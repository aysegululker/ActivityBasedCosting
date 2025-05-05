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
    public class CostItemMapping :IEntityTypeConfiguration<CostItem>
    {
        public void Configure(EntityTypeBuilder<CostItem> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.CostItemName).IsRequired();
            builder.Property(x => x.CPCostClass).IsRequired().HasMaxLength(10);
            builder.Property(x => x.CITCostClass).IsRequired().HasMaxLength(10);
            builder.Property(x => x.KmMultiplierEffect).IsRequired();
            builder.Property(x => x.ByProduct).IsRequired();
            builder.HasOne(x => x.DistributionKey).WithMany(x => x.CostItems).HasForeignKey(x => x.DistributionKeyID);
        }
    }
}
