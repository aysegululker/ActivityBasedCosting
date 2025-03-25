using ABC.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Entity
{
    public class CashCenterGroup: BaseEntity
    {
        //Nakit Merkezi Sinifi & Cash Center Group
        public string CashCenterGroupName { get; set; }



        //Bir NM sınıfının birden fazla NM'si olabilir.
        public virtual List<CashCenter> CashCenters { get; set; }
    }
}
