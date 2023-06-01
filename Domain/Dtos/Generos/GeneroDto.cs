using Domain.Entities;

namespace Domain.Dtos.Generos
{
    public class GeneroDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public static implicit operator GeneroDto(Genero entidade)
        {
            if (entidade == null)
                return default;

            GeneroDto dto = new GeneroDto();
            dto.Id = entidade.Id;
            dto.Descricao = entidade.Descricao;
            return dto;
        }
    }
}



