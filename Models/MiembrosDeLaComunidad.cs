namespace POOProgII.Models
{
    public abstract class MiembrosDeLaComunidad
    {
        public string? nombre { get; set; }
        public string? apellido { get; set; }
        public string? correo { get; set; }
        public string? telefono { get; set; }

        public abstract void guardar();

    }
}