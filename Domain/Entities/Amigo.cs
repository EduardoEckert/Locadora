namespace Domain.Entities
{
    public class Amigo : Pessoa
    {
        protected Amigo() { }

        public virtual Telefone Telefone { get; private set; }
        public virtual Endereco Endereco { get; private set; }
        public string Email { get; private set; }
        public virtual List<Emprestimo> Emprestimos{ get; private set; } = new List<Emprestimo>();
    }
}
