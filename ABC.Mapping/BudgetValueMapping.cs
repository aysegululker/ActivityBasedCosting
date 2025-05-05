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
    public class BudgetValueMapping : IEntityTypeConfiguration<BudgetValue>
    {
        public void Configure(EntityTypeBuilder<BudgetValue> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.BudgetPeriod).IsRequired().HasMaxLength(50);
            builder.Property(x => x.BudgetCost).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            //Many To Many or One To Many Tables
            builder.HasOne(x => x.CostItem).WithMany(x => x.BudgetValues).HasForeignKey(x => x.CostItemID);
            builder.HasOne(x => x.CashCenter).WithMany(x => x.BudgetValues).HasForeignKey(x => x.CashCenterID);
        }
    }
}
