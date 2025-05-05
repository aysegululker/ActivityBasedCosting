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
    public class DistributionKeyRepository : BaseRepository<DistributionKey>, IDistributionKeyRepository
    {
        private readonly AbcDB _dbcontext;
        public DistributionKeyRepository(AbcDB dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
