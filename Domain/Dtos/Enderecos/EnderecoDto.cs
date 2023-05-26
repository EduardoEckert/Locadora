using Domain.Entities;

namespace Domain.Dtos.Enderecos
{
    public class EnderecoDto
    {
        public int Id { get; set; }
        public string Uf { get; set; }
        public string Cidade { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }

        public static implicit operator EnderecoDto?(Endereco entidade)
        {
            if (entidade == null)
                return default;

            EnderecoDto dto = new EnderecoDto();
            dto.Id = entidade.Id;
            dto.Uf = entidade.Uf;
            dto.Cidade = entidade.Cidade;
            dto.Logradouro = entidade.Logradouro;
            dto.Numero = entidade.Numero;
            dto.Bairro = entidade.Bairro;
            dto.Complemento = entidade.Complemento;

            return dto;
        }
    }
}
