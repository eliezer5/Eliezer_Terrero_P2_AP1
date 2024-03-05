using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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


		[Range(0.1, double.MaxValue, ErrorMessage = "El rango debe ser mayor a 0")]
		public decimal Costo { get; set; }


        [ForeignKey("VehiculoId")]
        public ICollection<VehiculosDetalle?> VehiculosDetalles { get; set; } = new List<VehiculosDetalle?>();
    }
}
