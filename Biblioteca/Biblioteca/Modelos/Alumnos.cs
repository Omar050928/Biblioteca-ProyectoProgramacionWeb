using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Modelos
{
    public class Alumnos
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe ser un correo válido")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        public string? Correo { get; set; }
        [Required(ErrorMessage = "El grado es obligatorio")]
        [StringLength(2, ErrorMessage = "Maximo 2 caracteres")]
        public string? Grado { get; set; }
    }
}
