using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Modelos
{
    public class BibliotecaDBContext : DbContext
    {
        public BibliotecaDBContext(DbContextOptions<BibliotecaDBContext> options) : base(options) {
            
        }
        public DbSet<Alumnos> Alumnos { get; set; }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }
    }
}
