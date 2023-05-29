namespace Domain.Entities
{
    public class Telefone : Entity
    {
        protected Telefone() { }
        public Telefone(string ddd, string numero)
        {
            Ddd = ddd;
            Numero = numero;
        }
        public string Ddd { get; private set; }
        public string Numero { get; private set; }

        public void AtualizarTelefone(string ddd, string numero)
        {
            Ddd = ddd;
            Numero = numero;
        }
    }
}
