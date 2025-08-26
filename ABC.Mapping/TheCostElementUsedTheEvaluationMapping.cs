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
    public class TheCostElementUsedTheEvaluationMapping : IEntityTypeConfiguration<TheCostElementUsedTheEvaluation>
    {
        public void Configure(EntityTypeBuilder<TheCostElementUsedTheEvaluation> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.TheNameoftheCostElement).IsRequired().HasMaxLength(150);
        }
    }
    
}
