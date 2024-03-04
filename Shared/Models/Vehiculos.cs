using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Shared.Models
{
    public class Vehiculos
    {
        [Key]
        public int VehiculoId { get; set; }
        [Required(ErrorMessage = "El Campo es requerido")]
        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "El Campo es requerido")]
        public string Descripcion { get; set; }


		[Required(ErrorMessage = "El Campo es requerido")]
		public decimal Costo { get; set; }

		[Required(ErrorMessage = "El Campo es requerido")]
        public decimal Gasto { get; set; }

        public ICollection<VehiculosDetalle?> VehiculosDetalles { get; set; } = new List<VehiculosDetalle?>();
    }
}
