using Domain.Dtos;
using Domain.Entities;
using Domain.RepositoryInterfaces;
using Domain.ServiceInterfaces;

namespace Application.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly IPessoaRepository _repository;

        public PessoaService(IPessoaRepository repository) 
        {
            _repository = repository;
        }
        public IEnumerable<PessoaDto> GetAll()
        {
            return _repository.GetAll().Select(x => (PessoaDto)x);
        }
        public PessoaDto GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Insert(InsertPessoaDto dto)
        {
            var entity = new Pessoa(dto.Nome, dto.DataNascimento);
            _repository.Insert(entity);
        }

        public void Update(UpdatePessoaDto dto)
        {
            var entity = _repository.GetById(dto.Id);

            if (entity == null)
                throw new InvalidOperationException();

            entity.AtualizarPessoa(dto.Nome, dto.DataNascimento);
            _repository.Update(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
