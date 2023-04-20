namespace Domain.ValueObjects
{
    public class Endereco
    {
        public Endereco(
            string uf,
            string cidade,
            string logradouro,
            string numero,
            string bairro,
            string complemento)
        {
            Uf = uf;
            Cidade = cidade;
            Logradouro = logradouro;
            Numero = numero;
            Bairro = bairro;
            Complemento = complemento;
        }

        public string Uf { get; }
        public string Cidade { get; }
        public string Logradouro { get; }
        public string Numero { get; }
        public string Bairro { get; }
        public string Complemento { get; }
    }
}
