using Domain.Dtos;
using Domain.Dtos.Genero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ServiceInterfaces
{
    internal interface IGeneroService
    {
        IEnumerable<GeneroDto> GetAll();
        GeneroDto GetById(int id);
        void Insert(InsertGeneroDto dto);
        void Update(UpdateGeneroDto dto);
        void Delete(int id);
    }
}
