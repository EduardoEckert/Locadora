using Domain.Dtos.Telefones;

namespace Locadora.Model.Telefones
{
    public class TelefoneModel
    {
        public int Id { get; set; }
        public string Ddd {get; set; }
        public string Numero { get; set; }

        public static implicit operator TelefoneModel?(TelefoneDto? dto)
        {
            if (dto == null)
            {
                return null;
            }
            return new TelefoneModel
            {
                Id = dto.Id,
                Ddd = dto.Ddd
                Numero = dto.Numero,
            };
        }
    }
}

