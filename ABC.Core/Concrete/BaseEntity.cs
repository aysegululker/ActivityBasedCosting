using ABC.Core.Abstract;
using ABC.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Core.Concrete
{
    public class BaseEntity : IBaseEntity<Guid>, IEntity
    {
        public Guid ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime ModifiedDate { get; set; }
        public string ModifiedBy { get; set; } = string.Empty;
        public Status Status { get; set; }
    }
}
