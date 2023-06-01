using Domain.Dtos.Generos;

namespace Locadora.Model.Genero
{
    public class GeneroModel
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
