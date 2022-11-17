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

        Juguete Insertar(Juguete Juguete);

        Juguete Actualizar(int id, Juguete juguete);

        int Eliminar(int id);
    }

}
