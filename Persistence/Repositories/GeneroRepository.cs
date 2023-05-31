using Domain.Entities;
using Domain.RepositoryInterfaces;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class GeneroRepository : Repository<Genero>, IGeneroRepository
    {
        public GeneroRepository(LocadoraContext context) : base(context)
        {
        }
    }
}
