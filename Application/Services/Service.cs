using Domain.Entities;
using Domain.RepositoryInterfaces;
using Domain.ServiceInterfaces;

namespace Application.Services
{
    public abstract class Service<T> : IService<T> where T : Entity
    {
        private readonly IRepository<T> _repository;

        protected Service(IRepository<T> repository)
        {
            _repository = repository;
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T? GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
