using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Context
{
    public class LocadoraContext : DbContext
    {
        public LocadoraContext(DbContextOptions<LocadoraContext> options) : base(options)
        {

        }

        public DbSet<Amigo> Amigos { get; set; }
        public DbSet<Dvd> Dvds { get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dvd>()
                .HasOne(x => x.Diretor)
                .WithMany()
                .HasForeignKey(x => x.DiretorId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Dvd>()
                .HasOne(x => x.AtorPrincipal)
                .WithMany()
                .HasForeignKey(x => x.AtorPrincipalId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Amigo>()
                .ToTable("Amigos");

            modelBuilder.Entity<Pessoa>()
              .ToTable("Pessoas");

            base.OnModelCreating(modelBuilder);
        }
    }
}
