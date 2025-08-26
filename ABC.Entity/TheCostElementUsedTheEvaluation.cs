using ABC.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Entity
{
    public class TheCostElementUsedTheEvaluation : BaseEntity
    {
        //The Cost Element to be Used in the Evaluation
        //Değerlendirmede Kullanılacak Maliyet Unsuru
        public string TheNameoftheCostElement { get; set; } //Maliyet Unsuru Adı


        //Many To Many or One To Many Tables
        //Bir Maliyet Unsurunun birden fazla aktivitesi olabilir.
        public virtual List<Activity> Activities { get; set; } = new List<Activity>();
    }
}
