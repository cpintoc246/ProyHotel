using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyHotel.Models
{
    public class DataContextLPL : DbContext
    {
        public DataContextLPL(DbContextOptions<DataContextLPL> options) : base(options)
        {
        }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<Chat> Chat { get; set; }
        public DbSet<Caracteristica> Caracteristica { get; set; }
        public DbSet<Habitacion> Habitacion { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<HotelCaracteristica> HotelCaracteristica { get; set; }
        public DbSet<Imagen> Imagen { get; set; }
        public DbSet<ReservaDetalle> ReservaDetalle { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<ServicioExtra> ServicioExtra { get; set; }
        public DbSet<Suscripciones> Suscripciones { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

    }
}
