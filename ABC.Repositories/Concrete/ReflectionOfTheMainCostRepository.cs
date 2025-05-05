using ABC.DataAccess;
using ABC.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Repositories.Concrete
{
    public class ReflectionOfTheMainCostRepository : BaseRepository<ReflectionOfTheMainCost>
    {
        private readonly AbcDB _dbcontext;
        public ReflectionOfTheMainCostRepository(AbcDB dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
