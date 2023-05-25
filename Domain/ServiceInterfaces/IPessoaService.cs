using Domain.Dtos;

namespace Domain.ServiceInterfaces
{
    public interface IPessoaService
    {
        IEnumerable<PessoaDto> GetAll();
        PessoaDto GetById(int id);
        void Insert(InsertPessoaDto dto);
        void Update(UpdatePessoaDto dto);
        void Delete(int id);
    }
}