namespace Domain.Entities
{
    public class Emprestimo : Entity
    {
        protected Emprestimo() { }
        public DateTime Data{ get; private set; }
        public DateTime DataDevolucao{ get; private set; }
        public virtual Amigo Amigo{ get; private set; }
        public virtual Dvd Dvd{ get; private set; }
    }
}
