using Biblioteca.Modelos;

namespace Biblioteca.Repositorio
{
    public interface IRepositorioAlumnos
    {
        Task<List<Alumnos>> GetAll();
        Task<Alumnos?> Get(int id);
        Task<Alumnos> Add(Alumnos alumnos);
        Task Update(int id, Alumnos alumno);
        Task Delete(int id);
    }
}
