using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BLL;

namespace BLL
{
   public class EvaluacionesTareas
    {
        public int IdEstudiante { get; set; }
        public int IdEvaluacion { get; set; }
        public int Calificacion { get; set; }
        public int IdTarea { get; set; }
        public DateTime Fecha { get; set; }

        ConexionDb Conexion = new ConexionDb();

        public bool Insertar()
        {
            return Conexion.EjecutarDB("insert into EvaluacionesTareas(Fecha,IdEstudiante,Calificacion)values ('" + Fecha.ToString("MM/dd/yyyy HH:mm:ss") + "' , " + IdEstudiante + "," + Calificacion + ")");

        }

        public bool Modificar()
        {

            return Conexion.EjecuctarDB( " Update EvaluacionesTareas set Fecha = '" + Fecha.ToString("MM/dd/yyyy HH:mm:ss") + "', IdEstudiante=" + IdEstudiante + ", Calificacion=" + Calificacion + ", IdEvaluacion= " + IdEvaluacion);


        }


         public bool Eliminar(int prmIdEvaluacion)
        {
            return Conexion.EjecutarDB("Delete from EvaluacionesTareas where IdCalificacion = " + prmIdEvaluacion);
        }

        public bool Buscar(int prmIdEvaluacion)
        {
            DataTable Datos = new DataTable();
            bool Retorno = false;

            Datos = Conexion.BuscarDb("Select * from EvaluacionesTareas Where IdCalificacion=" + prmIdEvaluacion);

            if (Datos.Rows.Count > 0)
            {
                Retorno = true;

                this.IdEvaluacion = (int)Datos.Rows[0]["IdCalificacion"];
                this.Fecha = (DateTime)Datos.Rows[0]["Fecha"];
                this.IdEstudiante = (int)Datos.Rows[0]["IdEstudiante"];
                this.Calificacion = (int)Datos.Rows[0]["Calificacion"];
                
            }


            return Retorno;
        }

        public DataTable Listar(string FiltroWhere)
        {
            return Conexion.BuscarDb("Select * from EvaluacionesTareas Where " + FiltroWhere);
        }
    


    }
}
