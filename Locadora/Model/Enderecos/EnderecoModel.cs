using Domain.Dtos.Enderecos;

namespace Locadora.Model.Enderecos
{
    public class EnderecoModel
    {
        public int Id { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public static implicit operator EnderecoModel?(EnderecoDto? dto)
        {
            if (dto == null)
            {
                return null;
            }
            return new EnderecoModel
            {
                Id = dto.Id,
                Uf = dto.Uf,
                Cidade = dto.Cidade,
                Logradouro = dto.Logradouro,
                Numero = dto.Numero,
                Bairro = dto.Bairro,
                Complemento = dto.Complemento,
            };
        }
    }
}

