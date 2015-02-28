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

        public EvaluacionesTareas()
        {
            IdEstudiante = 0;
            IdEvaluacion = 0;
            Calificacion = 0;
            IdTarea = 0;
            Fecha = System.DateTime.Now;
        }

        public bool Insertar()
        {
            bool Devuelve = false;
            IdEvaluacion = Convert.ToInt32(Conexion.ObtenerValorDb("insert into EvaluacionesTareas(Fecha,IdEstudiante,Calificacion)values ('" + Fecha.ToString("MM/dd/yyyy HH:mm:ss") + "' , " + IdEstudiante + "," + Calificacion + ")select @@identity"));
            if (IdEvaluacion != 0)
            {
                Devuelve = true;
            }
            return Devuelve;
        }

        public bool Modificar()
        {
            bool Devuelve = false;
            Devuelve = Conexion.EjecuctarDB(" Update EvaluacionesTareas set Fecha = '" + Fecha.ToString("MM/dd/yyyy HH:mm:ss") + "', IdEstudiante=" + IdEstudiante + ", Calificacion=" + Calificacion + ", IdEvaluacion= " + IdEvaluacion);
            return Devuelve;
        }



        public static bool Eliminar(int prmIdEvaluacion)
        {
            ConexionDb Conexion = new ConexionDb();
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

        public DataTable Listar(string Campos,string FiltroWhere, string FiltroOrderBy)
        {
            return Conexion.BuscarDb("Select " + Campos + " from EvaluacionesTareas Where " + FiltroWhere + " Order By "+ FiltroOrderBy);
        }



    }
}
