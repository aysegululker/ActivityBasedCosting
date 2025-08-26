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
    public class KmValueMapping : IEntityTypeConfiguration<KmValue>
    {
        public void Configure(EntityTypeBuilder<KmValue> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.InnerCityKm).IsRequired();
            builder.Property(x => x.OuterCityKm).IsRequired();
            builder.HasOne(x => x.CashCenter).WithOne(x => x.KmValues).HasForeignKey<KmValue>(x => x.CashCenterID);
        }
    }
}
