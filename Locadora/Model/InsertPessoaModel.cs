using Domain.Dtos;
using System.ComponentModel.DataAnnotations;

namespace Locadora.Model
{
    public class InsertPessoaModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; }

        public static implicit operator InsertPessoaDto (InsertPessoaModel model) 
        {
            return new InsertPessoaDto { Nome = model.Nome };
        }
    }
    
}
