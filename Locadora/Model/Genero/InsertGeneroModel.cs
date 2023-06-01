using Domain.Dtos;
using Domain.Dtos.Generos;
using System.ComponentModel.DataAnnotations;

namespace Locadora.Model.Genero
{
    public class InsertGeneroModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Descrição obrigatória")]
        public string Descricao { get; set; }


        public static implicit operator InsertGeneroDto(InsertGeneroModel model)
        {
            return new InsertGeneroDto { Descricao = model.Descricao };
        }
    }
}
