using Domain.Dtos.Telefone;
using System.ComponentModel.DataAnnotations;

namespace Locadora.Model.Telefone
{
    public class InsertTelefoneModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ddd obrigatório")]
        public string Ddd { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Numero obrigatório")]
        public string Numero { get; set; }

        public static implicit operator InsertTelefoneDto(InsertTelefoneModel model)
        {
            return new InsertTelefoneDto
            {
                Ddd = model.Ddd;
                Numero = model.Numero,
            };
        }
    }
}
