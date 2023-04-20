using Domain.Entities;
using Domain.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        protected Repository(ControleEmprestimoContext context)
        {
            Context = context;
            Set = context.Set<T>();
        }

        protected ControleEmprestimoContext Context { get; }
        protected DbSet<T> Set { get; }

        public void Delete(int id)
        {
            var entity = Set.Find(id);

            if (entity != null)
                Set.Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return Set.ToList();
        }

        public T? GetById(int id)
        {
            return Set.Find(id);
        }

        public T Insert(T entity)
        {
            Set.Add(entity);

            return entity;
        }

        public void Update(T entity)
        {
            Set.Update(entity);
        }
    }
}
