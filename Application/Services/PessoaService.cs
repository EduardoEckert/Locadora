using Domain.Dtos;
using Domain.Entities;
using Domain.RepositoryInterfaces;
using Domain.ServiceInterfaces;

namespace Application.Services
{
    public class PessoaService : Service<Pessoa>, IPessoaService
    {
        private readonly IPessoaRepository _repository;

        public PessoaService(IPessoaRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public void Insert(InsertPessoaDto dto)
        {
            var entity = new Pessoa(dto.Nome);
            _repository.Insert(entity);
        }
    }
}
