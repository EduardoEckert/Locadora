namespace Domain.Entities
{
    public class Pessoa : Entity
    {
        protected Pessoa() { }
        public Pessoa(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public string Nome { get; private set; }
        public DateTime DataNascimento { get; private set; }

        public void AtualizarPessoa(string nome, DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public int CalcularIdade() 
        {
            return DataNascimento.Year - DateTime.Now.Year;
        }
    }
}
