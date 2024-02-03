namespace POOProgII.Models
{
    public class Estudiante : MiembrosDeLaComunidad
    {
        public string Matricula { get; set; }

        public string carrera { get; set; }

        public override void guardar()
        {
            throw new NotImplementedException();
        }
    }
}
