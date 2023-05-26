using Domain.Dtos.Telefones;
using System.ComponentModel.DataAnnotations;

namespace Locadora.Model.Telefone
{
    public class UpdateTelefonecoModel
    {
        [Required(ErrorMessage = "Id obrigatório")]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Ddd obrigatório")]
        public string Ddd { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Numero obrigatório")]
        public string Numero { get; set; }

        public static implicit operator UpdateTelefoneDto(UpdateTelefoneModel model)
        {
            return new UpdateTelefoneDto
            {
                Id = model.Id,
                Ddd = model.Ddd,
                Numero = model.Numero,
            };
        }
    }
}
