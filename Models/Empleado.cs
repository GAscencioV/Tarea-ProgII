namespace POOProgII.Models
{
    public class Empleado : MiembrosDeLaComunidad
    {
        public int id { get; set; }
        public double sueldo { get; set; }


        public override void guardar()
        {
            throw new NotImplementedException();
        }
    }
}
