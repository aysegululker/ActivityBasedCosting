using ABC.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Entity
{
    public class ServiceClass : BaseEntity
    {
        //Hizmet Sinifi & Service Class & CIT/CP Durumu
        public string ServiceClassName { get; set; }



        //Many To Many or One To Many Tables
        //Bir Hizmet Sınıfının birden fazla aktivitesi olabilir.
        public virtual List<Activity> Activities { get; set; } = new List<Activity>();
    }
}
