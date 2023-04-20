
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class ControleEmprestimoContext : DbContext
    {
        public ControleEmprestimoContext(DbContextOptions<ControleEmprestimoContext> options) : base(options)
        {
        }

        public DbSet<Pessoa> Pessoa { get; set; }
    }
}
