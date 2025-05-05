using ABC.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Entity
{
    public class DistributionKey : BaseEntity
    {
        //CIT&CP Dağılım Anahtarı & Distribution Key
        //Personel,m2, NM Süre & Personnel, m2, NM Time
        public string DistributionKeyName { get; set; }
        public float DistributionKeyRatio { get; set; }


        //Bir Dağıtım Anahtarı'nın birden fazla Maliyet Kalemi olabilir.
        public virtual List<CostItem> CostItems { get; set; } 
    }
}
