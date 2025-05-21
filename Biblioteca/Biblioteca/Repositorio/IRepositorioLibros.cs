using Biblioteca.Modelos;

namespace Biblioteca.Repositorio
{
    public interface IRepositorioLibros
    {
        Task<List<Libros>> GetAll();
        Task<Libros?> Get(int id);
        Task<Libros> Add(Libros libro);
        Task Update(int id, Libros libro);
        Task Delete(int id);

        Task<bool> canDelete(int id);
    }
}
