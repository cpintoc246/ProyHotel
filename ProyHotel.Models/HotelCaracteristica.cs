using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel.Models
{//internal
    public class HotelCaracteristica
    {
        [Key]
        public int IdHotelCaracteristica { get; set; }

        [ForeignKey("Hotel")]
        public int IdHotel { get; set; }

        [ForeignKey("Habitacion")]
        public int IdHabitacion { get; set; }

        [ForeignKey("Hotel")]
        public int IdCaracteristica { get; set; }

    }
}

