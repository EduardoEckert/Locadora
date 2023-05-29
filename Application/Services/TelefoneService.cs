using Domain.Dtos.Telefones;
using Domain.Entities;
using Domain.RepositoryInterfaces;
using Domain.ServiceInterfaces;

namespace Application.Services
{
    public class TelefoneService : ITelefoneService
    {
        private readonly ITelefoneRepository _repository;

        public TelefoneService(ITelefoneRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<TelefoneDto> GetAll()
        {
            return _repository.GetAll().Select(x => (TelefoneDto)x);
        }
        public TelefoneDto GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Insert(InsertTelefoneDto dto)
        {
            var entity = new Telefone(
                dto.Ddd,
                dto.Numero);

            _repository.Insert(entity);
        }

        public void Update(UpdateTelefoneDto dto)
        {
            var entity = _repository.GetById(dto.Id);

            if (entity == null)
                throw new InvalidOperationException();

            entity.AtualizarTelefone(
                dto.Ddd,
                dto.Numero);

            _repository.Update(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
