using Domain.Entities;

namespace Domain.Dtos.Pessoas
{
    public class PessoaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public static implicit operator PessoaDto?(Pessoa entidade)
        {
            if (entidade == null)
                return default;

            PessoaDto dto = new PessoaDto();
            dto.Id = entidade.Id;
            dto.Nome = entidade.Nome;
            dto.DataNascimento = entidade.DataNascimento;
            return dto;
        }
    }

}
