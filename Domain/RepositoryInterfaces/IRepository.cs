using Domain.Entities;

namespace Domain.RepositoryInterfaces
{
    public interface IRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        T? GetById(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
