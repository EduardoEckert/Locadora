using Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Dvd : Entity
    {
        protected Dvd() { }
        public Dvd(string titulo,
                   string sinopse,
                   Pessoa atorPrincipal,
                   Pessoa diretor,
                   Genero genero,
                   EFaixaEtaria faixaEtaria)
        {
            Titulo = titulo;
            Sinopse = sinopse;
            AtorPrincipal = atorPrincipal;
            Diretor = diretor;
            Genero = genero;
            FaixaEtaria = faixaEtaria;
        }

        [ForeignKey(name: "Diretor")]
        public int DiretorId { get; private set; }
        [ForeignKey(name: "AtorPrincipal")]
        public int AtorPrincipalId { get; private set; }
        public virtual Pessoa AtorPrincipal { get; private set; }
        public virtual Pessoa Diretor { get; private set; }
        public string Titulo { get; private set; }
        public string Sinopse { get; private set; }
        public virtual Genero Genero { get; private set; }
        public EFaixaEtaria FaixaEtaria { get; private set; }
    }
}
