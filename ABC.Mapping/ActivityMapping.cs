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
    public class ActivityMapping : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ActivityName).IsRequired();
            builder.Property(x => x.TotalPersonnelTime).IsRequired();
            builder.Property(x => x.TotalVehicleTime).IsRequired();
            builder.HasOne(x => x.ServiceClass).WithMany(x => x.Activities).HasForeignKey(x => x.ServiceClassID);
            builder.HasOne(x => x.TheCostElementUsedTheEvaluation).WithMany(x => x.Activities).HasForeignKey(x => x.TheCostElementUsedTheEvaluationID);
        }
    }
}
