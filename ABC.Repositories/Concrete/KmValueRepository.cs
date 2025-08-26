using ABC.Core.Abstract;
using ABC.DataAccess;
using ABC.Entity;
using ABC.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Repositories.Concrete
{
    public class KmValueRepository : BaseRepository<KmValue>, IKmValueRepository
    {
        private readonly AbcDB _dbcontext;
        public KmValueRepository(AbcDB dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
