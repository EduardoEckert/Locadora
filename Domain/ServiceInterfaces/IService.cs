using Domain.Entities;

namespace Domain.ServiceInterfaces
{
    public interface IService <T> where T : Entity
    {
        IEnumerable<T> GetAll();
        T? GetById(int id);
        void Delete(int id);
    }
}
