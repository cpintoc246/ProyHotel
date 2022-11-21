using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel.Models
{
    public class ReservaDetalle
    {
        [Key]
        public int IdReservaDetalle { get; set; }
        public int TotalDias { get; set; }
        public int Adultos { get; set; }
        public int Ninos { get; set; }
        public int Infantes { get; set; }
        public decimal CostoHabitacion { get; set; }

        [ForeignKey("Reserva")]
        public int IdReserva { get; set; }
        public virtual Reserva Reserva { get; set; }

        [ForeignKey("Habitacion")]
        public int IdHabitacion { get; set; }
        public virtual Habitacion Habitacion { get; set; }
    }
}

