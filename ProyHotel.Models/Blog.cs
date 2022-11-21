using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel.Models
{
    public class Blog
    {
        [Key]
        public int IdBlog { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Post { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaModificacion { get; set; }
        public string Tipo { get; set; }
        public string Categoria { get; set; }
        public string Video { get; set; }
        public string Imagen { get; set; }
        public int Consultas { get; set; }
        public string Tags { get; set; }
        public string MetaKeys { get; set; }
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

        [ForeignKey("ServicioExtra")]
        public int IdServicioExtra { get; set; }
        public virtual ServicioExtra ServicioExtra { get; set; }
    }
}
