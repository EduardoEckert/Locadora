using Domain.Dtos;

namespace Locadora.Model
{
    public class PessoaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DatasNascimento { get; set; }

        public static implicit operator PessoaModel?(PessoaDto? dto)
        {
            if (dto == null)
            {
                return null;
            }
            return new PessoaModel
            {
                Id = dto.Id,
                Nome = dto.Nome,
                DatasNascimento = dto.DataNascimento
            };
        }
    }
}
