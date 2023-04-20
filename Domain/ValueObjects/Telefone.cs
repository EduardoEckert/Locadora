namespace Domain.ValueObjects
{
    public class Telefone
    {
        public Telefone(string ddd, string numero)
        {
            Ddd = ddd;
            Numero = numero;
        }

        public string Ddd { get; }
        public string Numero { get; }
    }
}
