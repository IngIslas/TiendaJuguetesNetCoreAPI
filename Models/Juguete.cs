using System.ComponentModel.DataAnnotations;

namespace TiendaJuguetesAPI.Models
{
    public class Juguete
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        public int? RestriccionEdad { get; set; }

        [StringLength(50)]
        public string Compañia { get; set; }

        public decimal? Precio { get; set; }
    }
}
