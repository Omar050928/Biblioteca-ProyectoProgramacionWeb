using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Modelos
{
    public class Libros
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El titulo es obligatorio")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Titulo { get; set; }
        [Required(ErrorMessage = "El autor es obligatorio")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Autor { get; set; }
    }
}
