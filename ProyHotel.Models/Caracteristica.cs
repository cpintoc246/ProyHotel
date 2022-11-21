using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel.Models
{
    public class Caracteristica
    {
        [Key]
        public int IdCaracteristica { get; set; }
        public string Nombre { get; set; }
    }
}
