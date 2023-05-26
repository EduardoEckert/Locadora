using Domain.Dtos.Pessoas;
using System.ComponentModel.DataAnnotations;

namespace Locadora.Model.Pessoa
{
    public class InsertPessoaModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Insira uma data válida")]
        public DateTime DataNascimento { get; set; }

        public static implicit operator InsertPessoaDto(InsertPessoaModel model)
        {
            return new InsertPessoaDto { Nome = model.Nome, DataNascimento = model.DataNascimento };
        }
    }
}
