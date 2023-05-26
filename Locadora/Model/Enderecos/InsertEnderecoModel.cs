using Domain.Dtos.Enderecos;
using System.ComponentModel.DataAnnotations;

namespace Locadora.Model.Enderecos
{
    public class InsertEnderecoModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Uf é um campo obrigatório")]
        public string Uf { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Cidade é um campo obrigatório")]
        public string Cidade { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Logradouro é um campo obrigatório")]
        public string Logradouro { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Numero é um campo obrigatório")]
        public string Numero { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Bairro é um campo obrigatório")]
        public string Bairro { get; set; }
        public string Complemento { get; set; }

        public static implicit operator InsertEnderecoDto(InsertEnderecoModel model)
        {
            return new InsertEnderecoDto
            {
                Uf = model.Uf,
                Cidade = model.Cidade,
                Logradouro = model.Logradouro,
                Numero = model.Numero,
                Bairro = model.Bairro,
                Complemento = model.Complemento,
            };
        }
    }
}
