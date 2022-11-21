using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel.Models
{
    public class Reserva
    {
        [Key]
        public int IdReserva { get; set; }
        public string Folio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaReservaIni { get; set; }
        public DateTime FechaReservaFin { get; set; }
        public decimal CostoTotal { get; set; }
        public string Estatus { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Pais { get; set; }
        public string Cuidad { get; set; }
        public string Municipio { get; set; }
        public string Direccion { get; set; }
        public string CodigoPostal { get; set; }
        public string RequerimientosEsp { get; set; }
        public string ReferenciaPago { get; set; }
        public string Tipo { get; set; }

        [ForeignKey("Hotel")]
        public int IdHotel { get; set; }
        public virtual Hotel Hotel { get; set; }

    }
}
