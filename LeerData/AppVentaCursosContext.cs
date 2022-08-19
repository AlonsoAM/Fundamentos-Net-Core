using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeerData
{
    public class AppVentaCursosContext: DbContext
    {
        // Cargar la cadena de conexion
        // Data Source=localhost;Initial Catalog=CursosOnline;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        private const string connectionString = @"Data Source=localhost;Initial Catalog=CursosOnline;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        // Método para la conexion con la base de datos 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        // Indicarle que tiene doble llave primaria
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CursoInstructor>().HasKey(ci => new { ci.CursoID, ci.InstructorID });
        }

        // Crear DBSets para convertir nuestras tablas en Entidades u objetos
        public DbSet<Curso>? Curso { get; set; }
        public DbSet<Precio>? Precio { get; set; }
        public DbSet<Comentario>? Comentario { get; set; }
        public DbSet<Instructor>? Instructor { get; set; }
        public DbSet<CursoInstructor>? CursoInstructor { get; set; }
    }
}
