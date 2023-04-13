using Domain.Entities;

namespace Domain.RepositoryInterfaces
{
    public interface IRepository<T> where T : Entity
    {
        T GetById(int id);
        T GetAll();
        void Update(T entity);
        void Delete(int id);
    }
}
