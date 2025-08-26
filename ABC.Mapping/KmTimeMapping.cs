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
    public class KmTimeMapping : IEntityTypeConfiguration<KmTime>
    {
        public void Configure(EntityTypeBuilder<KmTime> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.KmTimeValue).IsRequired();
            builder.Property(x => x.InnerCityConsumption).IsRequired();
            builder.Property(x => x.OuterCityConsumption).IsRequired();
        }
    }
}
