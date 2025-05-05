using ABC.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Entity
{
    public class BudgetValue : BaseEntity
    {
        // Bütçe Değeri & Budget Value
        public string BudgetPeriod { get; set; }
        public float BudgetCost { get; set; }
        public string Description { get; set; }


        //Many To Many or One To Many Tables
        //Bir Bütçe Değeri'nin bir Maliyet Kalemi olabilir.
        //Bir Bütçe Değerinin bir NM'si olarabilir.
        public Guid CostItemID { get; set; }
        public Guid CashCenterID { get; set; }


        public virtual CostItem CostItem { get; set; }
        public virtual CashCenter CashCenter { get; set; }
    }
}
