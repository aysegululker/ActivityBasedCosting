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
    public class CashCenterMapping : IEntityTypeConfiguration<CashCenter>
    {
        public void Configure(EntityTypeBuilder<CashCenter> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.CashCenterCode).IsRequired();
            builder.Property(x => x.CashCenterName).IsRequired().HasMaxLength(50);
            builder.HasOne(x => x.CashCenterGroup).WithMany(x => x.CashCenters).HasForeignKey(x => x.CashCenterGroupID);

        }
    }
}
