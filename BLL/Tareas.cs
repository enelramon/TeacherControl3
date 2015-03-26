using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Tareas
    {
        public int IdTarea { get; set; }
        public string CodigoTarea { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Vence { get; set; }
        public int IdSemestre { get; set; }
        public int IdAsignatura { get; set; }
        public string Descripcion { get; set; }


        public Tareas()
        {
            IdTarea = 0;
            CodigoTarea = "";
            Fecha = DateTime.Now;
            Vence = DateTime.Now;
            IdSemestre = 0;
            IdAsignatura = 0;
            Descripcion = "";
        }

        public void Insertar()
        {
            ConexionDb conectar = new ConexionDb();
            IdTarea = (int)conectar.ObtenerValorDb("Insert Into Tareas(CodigoTarea,Fecha,Vence,IdSemestre,IdAsignatura,Descripcion) values ('" + this.CodigoTarea + "', '" + this.Fecha.ToString("yyyy/MM/dd") + "','" + this.Vence.ToString("yyyy/MM/dd") + "'," + this.IdSemestre + "," + this.IdAsignatura + "," + this.Descripcion + ") select @@identity ");
        }

        public bool Modificar()
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.EjecutarDB("Update Tareas set CodigoTarea ='" + this.CodigoTarea + "', Fecha ='" + this.Fecha.ToString("yyyy/MM/dd") + "', Vence ='" + this.Vence.ToString("yyyy/MM/dd") + "', IdAsignatura= " + this.IdAsignatura + ", Descripcion = '" + this.Descripcion + "' where " + this.IdTarea);
        }

        public static bool Eliminar(int id)
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.EjecutarDB("Delete From Tareas where "+ id);
        }

        public DataTable Listar(string campo, string filtro)
        {
            ConexionDb conectar = new ConexionDb();
            return conectar.BuscarDb("Select " + campo + " from Tareas where " + filtro);
        }

        public bool Buscar()
        {
            ConexionDb conectar = new ConexionDb();
            DataTable dt = new DataTable();
            bool msj = false;

            dt = conectar.BuscarDb("select * from Tareas where " + this.IdTarea);
            if (dt.Rows.Count > 0)
            {
                msj = true;
                this.CodigoTarea = (string)dt.Rows[0]["CodigoTarea"];
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
                this.Vence = (DateTime)dt.Rows[0]["Vence"];
                this.IdSemestre = (int)dt.Rows[0]["IdSemestre"];
                this.IdAsignatura = (int)dt.Rows[0]["IdAsignatura"];
                this.Descripcion = (string)dt.Rows[0]["Descripcion"];

            }
            return msj;
        }
    }
}
