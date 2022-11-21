using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel.Models
{
    public class ServicioExtra
    {
        [Key]
        public int IdServicioExtra { get; set; }
        public string Servicio { get; set; }
        public decimal Costo { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }

        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }

        [ForeignKey("Hotel")]
        public int IdHotel { get; set; }
        public virtual Hotel Hotel { get; set; }

        [ForeignKey("Habitacion")]
        public int IdHabitacion { get; set; }
        public virtual Habitacion Habitacion { get; set; }

    }
}
