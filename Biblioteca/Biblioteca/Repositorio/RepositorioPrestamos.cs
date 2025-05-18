using Microsoft.EntityFrameworkCore;
using Biblioteca.Modelos;

namespace Biblioteca.Repositorio
{
    public class RepositorioPrestamos : IRepositorioPrestamos
    {
        private readonly BibliotecaDBContext _context;

        public RepositorioPrestamos(BibliotecaDBContext context)
        {
            _context = context;
        }

        public async Task<Prestamos> Add(Prestamos prestamo)
        {
            await _context.Prestamos.AddAsync(prestamo);
            await _context.SaveChangesAsync();
            return prestamo;
        }

        public async Task Delete(int id)
        {
            var prestamo = await _context.Prestamos.FindAsync(id);
            if (prestamo != null)
            {
                _context.Prestamos.Remove(prestamo);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Prestamos?> Get(int id)
        {
            return await _context.Prestamos
                .Include(p => p.Alumno) 
                .Include(p => p.Libro)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Prestamos>> GetAll()
        {
            return await _context.Prestamos
                .Include(p => p.Alumno)
                .Include(p => p.Libro)
                .ToListAsync();
        }

        public async Task Update(int id, Prestamos prestamo)
        {
            var prestamoactual = await _context.Prestamos.FindAsync(id);
            if (prestamoactual != null)
            {
                prestamoactual.AlumnoId = prestamo.AlumnoId;
                prestamoactual.LibroId = prestamo.LibroId;
                prestamoactual.FechaPrestamo = prestamo.FechaPrestamo;
                prestamoactual.FechaDevolucion = prestamo.FechaDevolucion;
                await _context.SaveChangesAsync();
            }
        }
    }
}
