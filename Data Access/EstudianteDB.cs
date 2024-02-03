using POOProgII.Models;
using POOProgII.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOProgII.Data_Access
{
    public class EstudianteDB : IEstudiante
    {
        private readonly List<MiembrosDeLaComunidad> _Estudiantes;

        public EstudianteDB()
        {
            _Estudiantes = new List<MiembrosDeLaComunidad>();

        }
        public void Eliminar(MiembrosDeLaComunidad Estudiante)
        {
            _Estudiantes.Remove(Estudiante);
        }

        public bool Existe(MiembrosDeLaComunidad Estudiante)
        {
            return _Estudiantes.Exists(cd => cd.nombre == Estudiante.nombre);
        }

        public void Guardar(MiembrosDeLaComunidad Estudiante)
        {
            _Estudiantes.Add(Estudiante);
        }
    }
}
