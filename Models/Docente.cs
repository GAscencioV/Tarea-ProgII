namespace POOProgII.Models
{
    public class Docente : Empleado
    {
        public int id { get; set; }

        public DateTime? FechaIngreso { get; set; }

        public string? carrera { get; set; }

    }
}
