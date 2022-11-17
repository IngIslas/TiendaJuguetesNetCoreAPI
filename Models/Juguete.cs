using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace TiendaJuguetesAPI.Models
{
    [Table("Juguetes")]
    public class Juguete
    {
        public int Id { get; set; }

        [StringLength(50), Required, NotNull]
        public string Nombre { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        public int? RestriccionEdad { get; set; }

        [StringLength(50), Required, NotNull]
        public string Compañia { get; set; }

        [Required, NotNull]
        public decimal? Precio { get; set; }
    }
}
