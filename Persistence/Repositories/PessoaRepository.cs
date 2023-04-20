using Domain.Entities;
using Domain.RepositoryInterfaces;
using Persistence.Context;

namespace Persistence.Repositories
{
    public class PessoaRepository : Repository<Pessoa>, IPessoaRepository
    {
        public PessoaRepository(ControleEmprestimoContext context) : base(context)
        {
        }
    }
}
