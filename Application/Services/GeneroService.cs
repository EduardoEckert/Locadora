using Domain.Dtos.Generos;
using Domain.Entities;
using Domain.RepositoryInterfaces;
using Domain.ServiceInterfaces;

namespace Application.Services
{
    public class GeneroService : IGeneroService
    {
        private readonly IGeneroRepository _repository;

        public GeneroService(IGeneroRepository repository)
        {
            _repository = repository;
        }
        public IEnumerable<GeneroDto> GetAll()
        {
            return _repository.GetAll().Select(x => (GeneroDto)x);
        }
        public GeneroDto GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Insert(InsertGeneroDto dto)
        {
            var entity = new Genero(dto.Descricao);
            _repository.Insert(entity);
        }

        public void Update(UpdateGeneroDto dto)
        {
            var entity = _repository.GetById(dto.Id);

            if (entity == null)
                throw new InvalidOperationException();

            entity.AtualizarGenero(dto.Descricao);
            _repository.Update(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
