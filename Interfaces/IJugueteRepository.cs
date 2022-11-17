using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaJuguetesAPI.Models;

namespace TiendaJuguetesAPI.Interfaces
{
    public interface IJugueteRepository
    {   
        IEnumerable<Juguete> GetAll();

        Juguete GetById(int Id);

        int Insertar(Juguete Juguete);

        int Actualizar(int id, Juguete juguete);

        int Eliminar(int id);
    }

}
