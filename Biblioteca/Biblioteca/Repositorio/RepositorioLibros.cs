using Biblioteca.Modelos;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Repositorio
{
    public class RepositorioLibros : IRepositorioLibros
    {
        private readonly BibliotecaDBContext _context;

        public RepositorioLibros(BibliotecaDBContext context)
        {
            _context = context;
        }

        public async Task<Libros> Add(Libros libro)
        {
            await _context.Libros.AddAsync(libro);
            await _context.SaveChangesAsync();
            return libro;
        }

        public async Task Delete(int id)
        {
            var libro = await _context.Libros.FindAsync(id);
            if (libro != null)
            {
                _context.Libros.Remove(libro);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Libros?> Get(int id)
        {
            return await _context.Libros.FindAsync(id);
        }

        public async Task<List<Libros>> GetAll()
        {
            return await _context.Libros.ToListAsync();
        }

        public async Task Update(int id, Libros libro)
        {
            var librocatual = await _context.Libros.FindAsync(id);
            if (librocatual != null)
            {
                librocatual.Titulo = libro.Titulo;
                librocatual.Autor = libro.Autor;
                await _context.SaveChangesAsync();
            }
        }
    }
}
