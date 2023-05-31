namespace Domain.Entities
{
    public class Endereco : Entity
    {
        protected Endereco() { }
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

        public string Uf { get; private set; }
        public string Cidade { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Bairro { get; private set; }
        public string Complemento { get; private set; }

        public void AtualizarEndereco(
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
    }
}