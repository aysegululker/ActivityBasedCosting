using ABC.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Entity
{
    public class CostItem : BaseEntity
    {
        //Maliyet Kalemi & Cost Item
        public string CostItemName { get; set; } //Maliyet Kalemi Adı
        public string CPCostClass { get; set; } //CP Maliyet Sınıfı
        public string CITCostClass { get; set; } //CIT Maliyet Sınıfı
        public bool KmMultiplierEffect { get; set; } //Km Çarpanı Etkisi
        public bool ByProduct { get; set; } //Yan Ürün Mü?


        //Many To Many or One To Many Tables
        public Guid DistributionKeyID { get; set; }

        //Bir Maliyet Kalemi'nin bir Dağıtım Anahtarı olabilir.
        public virtual DistributionKey DistributionKey { get; set; }

        //Bir Maliyet Kalemi'nin birden fazla Bütçe Değeri olabilir.
        public virtual List<BudgetValue> BudgetValues { get; set; } = new List<BudgetValue>();
    }
}
