namespace Domain.Entities
{
    public class Genero : Entity
    {
        protected Genero() { }
        public Genero(string descricao)
        {
            Descricao = descricao;
        }

        public string Descricao { get; private set; }

        public void AtualizarGenero(string descricao)
        {
            Descricao = descricao;

        }
    }
}