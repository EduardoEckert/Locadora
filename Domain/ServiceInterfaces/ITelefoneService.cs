using Domain.Dtos.Telefone;

namespace Domain.ServiceInterfaces
{
    public interface ITelefoneService
    {
        IEnumerable<TelefoneDto> GetAll();
        EnderecoDto GetById(int id);
        void Insert(InsertTelefoneDto dto);
        void Update(UpdateTelefoneDto dto);
        void Delete(int id);
    }
}
