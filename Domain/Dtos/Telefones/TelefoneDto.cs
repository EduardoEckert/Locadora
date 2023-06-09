using Domain.Entities;

namespace Domain.Dtos.Telefones
{
    public class TelefoneDto
    {
        public int Id { get; set; }
        public string Ddd { get; set; }
        public string Numero { get; set; }

        public static implicit operator TelefoneDto?(Telefone entidade)
        {
            if (entidade == null)
                return default;

            TelefoneDto dto = new TelefoneDto();
            dto.Id = entidade.Id;
            dto.Ddd = entidade.Ddd;
            dto.Numero = entidade.Numero;

            return dto;
        }
    }
}
