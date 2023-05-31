using Domain.Dtos.Enderecos;
using Domain.Dtos.Telefones;

namespace Domain.ServiceInterfaces
{
    public interface ITelefoneService
    {
        IEnumerable<TelefoneDto> GetAll();
        TelefoneDto GetById(int id);
        void Insert(InsertTelefoneDto dto);
        void Update(UpdateTelefoneDto dto);
        void Delete(int id);
    }
}
