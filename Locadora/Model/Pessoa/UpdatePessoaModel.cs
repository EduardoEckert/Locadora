using Domain.Dtos;
using System.ComponentModel.DataAnnotations;

namespace Locadora.Model
{
    public class UpdatePessoaModel
    {
        [Required(ErrorMessage = "Id obrigatório")]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Nome obrigatório")]
        public string Nome { get; set; }
        public static implicit operator UpdatePessoaDto(UpdatePessoaModel model)
        {
            return new UpdatePessoaDto { Id = model.Id, Nome = model.Nome };
        }
    }
}
