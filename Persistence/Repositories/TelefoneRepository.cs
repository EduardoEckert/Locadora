using Domain.Entities;
using Domain.RepositoryInterfaces;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class TelefoneRepository : Repository<Telefone>, ITelefoneRepository
    {
        public TelefoneRepository(LocadoraContext context) : base(context)
        {
        }
    }
}
