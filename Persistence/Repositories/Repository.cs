using Domain.Entities;
using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        protected Repository(LocadoraContext context)
        {
            Context = context;
            Set = context.Set<T>();
        }

        protected LocadoraContext Context { get; }
        protected DbSet<T> Set { get; }

        public IEnumerable<T> GetAll()
        {
            return Set.ToList();
        }

        public T? GetById(int id)
        {
            return Set.Find(id);
        }

        public void Insert(T entity)
        {
            Set.Add(entity);
            Context.SaveChanges();
        }

        public void Update(T entity)
        {
            Set.Update(entity);
            Context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = Set.Find(id);

            if (entity != null)
                Set.Remove(entity);
            Context.SaveChanges();
        }
    }
}
