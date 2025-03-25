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
    public class ServiceClassMapping : IEntityTypeConfiguration<ServiceClass>
    {
        public void Configure(EntityTypeBuilder<ServiceClass> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ServiceClassName).IsRequired().HasMaxLength(5);
        }
    }
}
