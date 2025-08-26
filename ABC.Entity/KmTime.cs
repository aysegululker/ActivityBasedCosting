using ABC.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Entity
{
    public class KmTime : BaseEntity
    {
        //Km Süresi & Km Time
        public float KmTimeValue { get; set; } //Fiyatlanan Km Pers. Süre Karşılığı
        public float InnerCityConsumption { get; set; } //Şehir İçi Sarfiyat
        public float OuterCityConsumption { get; set; } //Şehir Dışı Sarfiyat
    }
}
