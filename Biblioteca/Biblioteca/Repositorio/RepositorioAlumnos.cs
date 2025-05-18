using Biblioteca.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Repositorio
{
    public class RepositorioAlumnos : IRepositorioAlumnos
    {
        private readonly BibliotecaDBContext _context;

        public RepositorioAlumnos(BibliotecaDBContext context)
        {
            _context = context;
        }

        public async Task<Alumnos> Add(Alumnos alumno)
        {
            await _context.Alumnos.AddAsync(alumno);
            await _context.SaveChangesAsync();
            return alumno;
        }

        public async Task Delete(int id)
        {
            var alumno = await _context.Alumnos.FindAsync(id);
            if (alumno != null)
            {
                _context.Alumnos.Remove(alumno);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Alumnos?> Get(int id)
        {
            return await _context.Alumnos.FindAsync(id);
        }

        public async Task<List<Alumnos>> GetAll()
        {
            return await _context.Alumnos.ToListAsync();
        }

        public async Task Update(int id, Alumnos alumno)
        {
            var alumnoactual = await _context.Alumnos.FindAsync(id);
            if (alumnoactual != null)
            {
                alumnoactual.Nombre = alumno.Nombre;
                alumnoactual.Correo = alumno.Correo;
                alumnoactual.Grado = alumno.Grado;
                await _context.SaveChangesAsync();
            }
        }

    }
}
