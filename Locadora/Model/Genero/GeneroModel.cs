using Domain.Dtos;

namespace Locadora.Model
{
    public class GeneroaModel
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    

        public static implicit operator GeneroModel?(GeneroDto? dto)
        {
            if (dto == null)
            {
                return null;
            }
            return new GeneroModel
            {
                Id = dto.Id,
                Descricao = dto.Descricao
            
            };
        }
    }
}
