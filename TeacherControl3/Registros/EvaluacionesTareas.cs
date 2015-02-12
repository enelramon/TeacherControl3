using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeacherControl3.Registros
{
    class EvaluacionesTareas
    {
        public string IdEvaluacion { get; set; }

        public DateTime Fecha { get; set; }

        public string IdTarea { get; set; }

        public string Calificacion { get; set; }

        public string IdEstudiante { get; set; }

        internal void Buscar(int p)
        {
            throw new NotImplementedException();
        }

        internal void Insertar()
        {
            throw new NotImplementedException();
        }

        internal void Eliminar(int p)
        {
            throw new NotImplementedException();
        }
    }
}
