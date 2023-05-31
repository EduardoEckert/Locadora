using Domain.Dtos.Enderecos;

namespace Domain.ServiceInterfaces
{
    public interface IEnderecoService
    {
        IEnumerable<EnderecoDto> GetAll();
        EnderecoDto GetById(int id);
        void Insert(InsertEnderecoDto dto);
        void Update(UpdateEnderecoDto dto);
        void Delete(int id);
    }
}
