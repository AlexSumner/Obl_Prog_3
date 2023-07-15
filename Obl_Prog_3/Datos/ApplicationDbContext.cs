using Microsoft.EntityFrameworkCore;
using Obl_Prog_3.Models;

namespace PruebaProgramacion3_Guia.Datos

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Persona> Personas { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Administrativo> Administrativos { get; set;}

        public DbSet<Sala> Salas { get; set; }  

        public DbSet<Pelicula> Peliculas { get; set; }  
        
        public DbSet<Funcion> Funciones { get; set; }

        public DbSet<Reserva> Reservas { get; set;}



    }
}