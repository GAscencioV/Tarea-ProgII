namespace POOProgII.Models
{
    public class ExAlumno : MiembrosDeLaComunidad
    {
        public DateTime FechaGraduacion { get; set; }
        public override void guardar()
        {
            throw new NotImplementedException();
        }
    }
}
