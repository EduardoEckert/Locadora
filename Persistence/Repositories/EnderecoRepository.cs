using Domain.Entities;
using Domain.RepositoryInterfaces;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(LocadoraContext context) : base(context)
        {
        }
    }
}
