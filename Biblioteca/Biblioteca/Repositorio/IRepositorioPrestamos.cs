using Biblioteca.Modelos;

namespace Biblioteca.Repositorio
{
    public interface IRepositorioPrestamos
    {
        Task<List<Prestamos>> GetAll();
        Task<Prestamos?> Get(int id);
        Task<Prestamos> Add(Prestamos prestamos);
        Task Update(int id, Prestamos prestamos);
        Task Delete(int id);
    }
}
