using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatternHW.DataLayer.Abstracts
{
    public interface IRepository<T> where T : class
    {
        T Get(Expression<Func<T, bool>> filter);
        IQueryable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
