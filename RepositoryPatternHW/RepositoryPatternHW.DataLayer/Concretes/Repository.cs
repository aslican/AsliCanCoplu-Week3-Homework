using RepositoryPatternHW.DataLayer.Abstracts;
using RepositoryPatternHW.DataLayer.Context;
using RepositoryPatternHW.Domain;
using System.Linq.Expressions;


namespace RepositoryPatternHW.DataLayer.Concretes
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public AppDbContext Context { get;}

        public Repository(AppDbContext context)
        {
            Context = context;
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
        }

        public void Delete(T entity)
        {
            var deletedMovie = Context.Set<T>().SingleOrDefault(p => p.Id == entity.Id);
            if (deletedMovie != null)
            {
                Context.Set<T>().Remove(deletedMovie);
                Context.SaveChanges();
            }
            else
            {
                throw new InvalidOperationException("Sorry guys.The movie not found.");
            }

        }

        public T Get(Expression<Func<T, bool>> x)
        {
            var movie= Context.Set<T>().SingleOrDefault(x);
            if (movie != null)
            {
                return movie;   
            }
            else
            {
                throw new Exception("The movie is not found. Maybe you can add :)");
            }
                    
        }

        public IQueryable<T> GetAll()
        {
            return Context.Set<T>().AsQueryable();
         
        }

        public void Update(T entity)
        {
            Context.Entry(entity).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
            Context.SaveChanges();
        }
    }
}

