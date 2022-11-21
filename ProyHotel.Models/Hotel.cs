using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel.Models
{
    public class Hotel
    {
        [Key]
        public int IdHotel { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string PalabrasClave { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public string Cuidad { get; set; }
        public string CodigoPostal { get; set; }
        public decimal Latitud { get; set; }
        public decimal Longitud { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Pinterest { get; set; }
        public string Linkedin { get; set; }
        public string WhatsApp { get; set; }
        public string TickTock { get; set; }
        public string Instagram { get; set; }
        public bool Facturacion { get; set; }
        public decimal Calificacion { get; set; }
        public bool Estatus { get; set; }
        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
