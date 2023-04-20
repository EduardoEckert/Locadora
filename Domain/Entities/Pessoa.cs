namespace Domain.Entities
{
    public class Pessoa : Entity
    {
        protected Pessoa() { }
        public string Nome { get; private set; }
    }
}
