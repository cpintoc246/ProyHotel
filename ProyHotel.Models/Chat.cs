using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel.Models
{
    internal class Chat
    {
        [Key]
        public int IdChat { get; set; }
        public string Nombre { get; set; }
        public string Mensaje { get; set; }
        public DateTime Fecha { get; set; }
        public string De { get; set; }
        public string Para { get; set; }

        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}

