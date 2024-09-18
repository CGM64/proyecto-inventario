using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace proyecto_inventario.Models
{
    public class Inventario
    {
        public int Id { get; set; }

        [DisplayName("Inventario de entrada")]
        [MaxLength(150)]
        [Required]
        public int? InvEntrada { get; set; }

        [DisplayName("Inventario de salida")]
        [MaxLength(150)]
        [Required]
        public int? InvSalida { get; set; }

        [DisplayName("Inventario de stock")]
        [MaxLength(150)]
        [Required]
        public int? InvStock { get; set; }
    }
}
