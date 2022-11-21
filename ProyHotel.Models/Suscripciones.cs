using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel.Models
{
    public class Suscripciones
    {
        [Key]
        public int IdSuscripciones { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }
    }
}
