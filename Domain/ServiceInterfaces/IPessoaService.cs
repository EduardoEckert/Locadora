using Domain.Dtos;
using Domain.Entities;

namespace Domain.ServiceInterfaces
{
    public interface IPessoaService : IService <Pessoa>
    {
        void Insert(InsertPessoaDto dto);
        //void Update(IUpdatePessoaDto dto);
    }
}