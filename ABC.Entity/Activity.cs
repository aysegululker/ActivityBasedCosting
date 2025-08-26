using ABC.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Entity
{
    public class Activity : BaseEntity
    {
        //Aktivite
        public string ActivityName { get; set; } //Aktivite Adı
        public short NumberofPersonnel { get; set; } //Personel Sayısı
        public short ActivityTime { get; set; } //Aktivite Süresi
        public short TotalPersonnelTime { get; set; } //Toplam Personel Sayısı
        public short TotalVehicleTime { get; set; } //Toplam Araç Süresi


        //Many To Many or One To Many Tables
        public Guid ServiceClassID { get; set; }
        public Guid TheCostElementUsedTheEvaluationID { get; set; }

        //Bir aktivitenin bir Hizmet Sınfı olabilir.
        public virtual ServiceClass ServiceClass { get; set; }

        //Bir aktivitenin bir Maliyet Unsuru olabilir.
        public virtual TheCostElementUsedTheEvaluation TheCostElementUsedTheEvaluation { get; set; }

    }
}
