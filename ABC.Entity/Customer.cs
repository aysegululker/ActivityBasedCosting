using ABC.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Entity
{
    public class Customer : BaseEntity
    {
        //Musteri & Customer
        public short CustomerCode { get; set; }
        public string CustomerName { get; set; }
    }
}
