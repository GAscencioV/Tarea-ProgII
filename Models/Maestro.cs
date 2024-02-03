namespace POOProgII.Models
{
    public class Maestro : Docente
    {
        public int id { get; set; }

        public List<String> Asignaturas { get; set; }

        public List<String> Secciones { get; set; }
    }
}
