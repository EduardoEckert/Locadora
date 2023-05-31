using Domain.Dtos.Enderecos;
using Domain.Entities;
using Domain.RepositoryInterfaces;
using Domain.ServiceInterfaces;

namespace Application.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IEnderecoRepository _repository;

        public EnderecoService(IEnderecoRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<EnderecoDto> GetAll()
        {
            return _repository.GetAll().Select(x => (EnderecoDto)x);
        }
        public EnderecoDto GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Insert(InsertEnderecoDto dto)
        {
            var entity = new Endereco(
                dto.Uf,
                dto.Cidade,
                dto.Logradouro,
                dto.Numero,
                dto.Bairro,
                dto.Complemento);

            _repository.Insert(entity);
        }

        public void Update(UpdateEnderecoDto dto)
        {
            var entity = _repository.GetById(dto.Id);

            if (entity == null)
                throw new InvalidOperationException();

            entity.AtualizarEndereco(
                dto.Uf,
                dto.Cidade,
                dto.Logradouro,
                dto.Numero,
                dto.Bairro,
                dto.Complemento);

            _repository.Update(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
