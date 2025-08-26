using ABC.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Entity
{
    public class KmValue : BaseEntity
    {
        //Km Değeri & Km Value
        public float InnerCityKm { get; set; } //Şehir İçi Km
        public float OuterCityKm { get; set; } //Şehir Dışı Km

        //Toplam Km Hesaplama
        public float TotalKm  => InnerCityKm + OuterCityKm;

        //Şehir İçi Km Oranı Hesaplama
        public float InnerCityKmRate => TotalKm == 0 ? 0 : (InnerCityKm / TotalKm);

        //Şehir Dışı Km Oranı Hesaplama
        public float OuterCityKmRate => TotalKm == 0 ? 0 : (OuterCityKm / TotalKm);


        // Sarfiyat Etkili Şehir Dışı Km Oranı
        public float ConsumptionEffectiveOutsideCityKmRate (KmTime kmTime)
        {
            float numerator = OuterCityKmRate * kmTime.OuterCityConsumption;
            float denominator = (InnerCityKmRate * kmTime.InnerCityConsumption) +
                                 (OuterCityKmRate * kmTime.OuterCityConsumption);
            return denominator == 0 ? 0 : (numerator / denominator);
        }

        //Şehir Dışı Km Süresi Hesaplama
        public float OuterCityKmTime(KmTime kmTime) => OuterCityKm * kmTime.KmTimeValue;


        //Many To Many or One To Many Tables
        public Guid CashCenterID { get; set; }




        //Bir Km Değerinin bir Nakit Merkezi olabilir.
        public virtual CashCenter CashCenter { get; set; }


    }
}
