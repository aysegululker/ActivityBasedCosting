using ABC.Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Entity
{
    public class CashCenter : BaseEntity
    {
        //Nakit Merkezi

        bool _isCashAssigned;
        short _cashCenterCode;
        public short CashCenterCode
        {
            get
            {
                return _cashCenterCode;
            }
            set
            {
                _cashCenterCode = value;
                _isCashAssigned = true;
            }
        }

        public string CCNo
        {
            get
            {
                if (!_isCashAssigned) throw new Exception("CashCenterCode atanmamış lütfen önce onu veriniz");
                return $"CC{_cashCenterCode}";
            }
        }

        public string CashCenterName { get; set; }

    }
}
