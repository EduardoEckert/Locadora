using Domain.Dtos;
using System.ComponentModel.DataAnnotations;

namespace Locadora.Model
{
    public class UpdateGeneroModel
    {
        [Required(ErrorMessage = "Id obrigatório")]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Descrição obrigatória")]
        public string Descricao { get; set; }
        public static implicit operator UpdateGeneroDto(UpdateGeneroModel model)
        {
            return new UpdateGeneroDto { Id = model.Id, Descricao = model.Descricao };
        }
    }
}
