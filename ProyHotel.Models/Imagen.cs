using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel.Models
{
    public class Imagen
    {

        [Key]
        public int IdImagen { get; set; }
        public string Imagenes { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }

        [ForeignKey("Hotel")]
        public int IdHotel { get; set; }
        public virtual Hotel Hotel { get; set; }

        [ForeignKey("Habitacion")]
        public int IdHabitacion { get; set; }
        public virtual Habitacion Habitacion { get; set; }

        [ForeignKey("Blog")]
        public int IdBlog { get; set; }
        public virtual Blog Blog { get; set; }

        [ForeignKey("ServicioExtra")]
        public int IdServicioExtra { get; set; }
        public virtual ServicioExtra ServicioExtra { get; set; }
    }
}

