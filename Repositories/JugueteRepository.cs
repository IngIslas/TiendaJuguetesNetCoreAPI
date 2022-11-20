using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TiendaJuguetesAPI.Conexions;
using TiendaJuguetesAPI.Interfaces;
using TiendaJuguetesAPI.Models;

namespace TiendaJuguetesAPI.Repositories
{
    public class JugueteRepository : IJugueteRepository
    {
        private readonly TiendaContext _context;

        public JugueteRepository(TiendaContext context)
        {
            _context = context;
        }


        public IEnumerable<Juguete> GetAll()
        {
            var juguetes = _context.Juguetes.ToList();
            return juguetes;
        }

        public Juguete GetById(int id)
        {
            var juguete = _context.Juguetes.FirstOrDefault(x => x.Id == id);
            return juguete;
        }

        public int Insertar(Juguete Juguete)
        {
            var result = _context.Add(Juguete);
            return _context.SaveChanges();
        }
        public int Actualizar(int id, Juguete juguete)
        {
            var _juguete = _context.Juguetes.FirstOrDefault(x => x.Id == id);
            _juguete.Nombre = juguete.Nombre;
            _juguete.Descripcion = juguete.Descripcion;
            _juguete.RestriccionEdad = juguete.RestriccionEdad;
            _juguete.Compañia = juguete.Compañia;
            _juguete.Precio = juguete.Precio;
            _context.Update(_juguete);
            return _context.SaveChanges();
        }

        public int Eliminar(int id)
        {
            var juguete = _context.Juguetes.FirstOrDefault(x => x.Id == id);
            _context.Remove(juguete);
            return _context.SaveChanges();
        }
    }
}
