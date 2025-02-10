using ABC.Core.Abstract;
using ABC.Core.Enums;
using ABC.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ABC.Repositories.Concrete
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IEntity, new()
    {
        private readonly AbcDB _dbContext;
        public BaseRepository(AbcDB dbContext)
        {
            _dbContext = dbContext;
        }

        public bool Add(T item)
        {
            try
            {
                item.CreatedDate = DateTime.Now;
                item.Status = Status.Active;
                _dbContext.Set<T>().Add(item);
                var ess = Save();
                return ess > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(T item)
        {
            try
            {
                item.ModifiedDate = DateTime.Now;
                item.Status = Status.Modified;
                _dbContext.Set<T>().Update(item);
                return Save() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<T> GetActive()
        {
            return _dbContext.Set<T>().Where(x => x.Status == Status.Active).ToList();
        }

        public List<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression)
        {
            return _dbContext.Set<T>().Where(expression).ToList();
        }

        public List<T> GetBy(Expression<Func<T, bool>> expression)
        {
            return _dbContext.Set<T>().Where(expression).ToList();
        }

        public T GetByFilter(Expression<Func<T, bool>> expression)
        {
            return _dbContext.Set<T>().Where(expression).FirstOrDefault();
        }

        public bool Remove(T item)
        {
            item.ModifiedDate = DateTime.Now;
            item.Status = Status.Deleted;
            return Edit(item);
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }
    }
}
