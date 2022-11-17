using Microsoft.EntityFrameworkCore;
using TiendaJuguetesAPI.Models;

namespace TiendaJuguetesAPI.Conexions
{
    public class TiendaContext: DbContext
    {

        public TiendaContext(DbContextOptions<TiendaContext> options) : base(options) { 
        }

        
        public DbSet<Juguete> Juguetes { get; set; }
    }
}
