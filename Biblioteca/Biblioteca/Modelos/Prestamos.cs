namespace Biblioteca.Modelos
{
    public class Prestamos
    {   
        public int Id { get; set; }

        public int AlumnoId { get; set; }
        virtual public Alumnos? Alumno { get; set; }

        public int LibroId { get; set; }
        virtual public Libros? Libro { get; set; }

        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaDevolucion { get; set; }

    }
}
