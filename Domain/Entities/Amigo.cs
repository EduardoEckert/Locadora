using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Amigo : Pessoa
    {
        protected Amigo() { }

        public Telefone Telefone { get; private set; }
        public Endereco Endereco { get; private set; }
        public string Email { get; private set; }
    }
}
