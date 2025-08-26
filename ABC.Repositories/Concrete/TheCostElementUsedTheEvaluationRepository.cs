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
    public class TheCostElementUsedTheEvaluationRepository : BaseRepository<TheCostElementUsedTheEvaluation>, ITheCostElementUsedTheEvaluationRepository
    {
        private readonly AbcDB _dbcontext;
        public TheCostElementUsedTheEvaluationRepository(AbcDB dbcontext) : base(dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
