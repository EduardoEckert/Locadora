namespace Domain.Dtos.Pessoas
{
    public class UpdatePessoaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
