using Microsoft.EntityFrameworkCore;
using ActiveAssets.DAL.Entities;

namespace ActiveAssets.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext>options) : base(options)
        {

        }

        public DbSet<Propietario> Propietarios { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<TelefonoPropietario> TelefonosPropietarios { get; set; }

        public DbSet<TelefonoCliente> TelefonosClientes { get; set; }

        public DbSet<TipoInmueble> TiposInmuebles { get; set; }

        public DbSet<Inmueble> Inmuebles { get; set; }

        public DbSet<SolicitudCompraArriendo> SolicitudesCompraArriendo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Propietario>().HasIndex(c => c.Cedula).IsUnique();
            modelBuilder.Entity<Cliente>().HasIndex(c => c.Cedula).IsUnique();
            modelBuilder.Entity<TelefonoPropietario>().HasIndex(c => c.CedulaPropietario).IsUnique();
            modelBuilder.Entity<TelefonoCliente>().HasIndex(c => c.CedulaCliente).IsUnique();
            modelBuilder.Entity<TipoInmueble>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<Inmueble>().HasIndex(c => c.Id).IsUnique();
            modelBuilder.Entity<SolicitudCompraArriendo>().HasIndex(c => c.Id).IsUnique();
        }
    }
}
