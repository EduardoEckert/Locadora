namespace Domain.Entities
{
    public class Pessoa : Entity
    {
        protected Pessoa() { }
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
    }
}
