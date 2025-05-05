using ABC.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ABC.Mapping
{
    public class ReflectionOfTheMainCostMapping : IEntityTypeConfiguration<ReflectionOfTheMainCost>
    {
        public void Configure(EntityTypeBuilder<ReflectionOfTheMainCost> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ReflectionOfTheMainCostRatio).IsRequired();
        }
    }
}
