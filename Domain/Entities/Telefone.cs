namespace Domain.Entities
{
    public class Telefone : Entity
    {
        protected Telefone() { }
        public string Ddd { get; private set; }
        public string Numero { get; private set; }
    }
}
