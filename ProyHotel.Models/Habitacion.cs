using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel.Models
{
    public class Habitacion
    {
        [Key]
        public int IdHabitacion { get; set; }
        public string Titulo { get; set; }
        public string PalabrasClave { get; set; }
        public string Descripcion { get; set; }
        public decimal Costo { get; set; }
        public int Adultos { get; set; }
        public int Ninos { get; set; }
        public int Infantes { get; set; }
        public int MaxAdultos { get; set; }
        public int MaxNinos { get; set; }
        public int MaxInfantes { get; set; }
        public int CostoAddAdultos { get; set; }
        public int CostoAddNinos { get; set; }
        public int CostoAddInfantes { get; set; }
        public int TotalHabitacions { get; set; }
        public decimal Calificacion { get; set; }
        public int Activo { get; set; }

        [ForeignKey("Hotel")]
        public int IdHotel { get; set; }
        public virtual Hotel Hotel { get; set; }

    }
}

