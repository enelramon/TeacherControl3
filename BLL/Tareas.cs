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
       public int IdSemestre{ get; set; }
       public int IdAsignatura{ get; set; }
       public int IdSeccion { get; set; }
       public string Descripcion { get; set; }
       ConexionDb conectar = new ConexionDb();

       public Tareas() 
       {
           IdTarea = 0;
           CodigoTarea = "";
           Fecha = DateTime.Now;
           Vence = DateTime.Now;
           IdSemestre = 0;
           IdAsignatura = 0;
           IdSeccion = 0;
           Descripcion = "";
       }

       public void Insertar() 
       {
           conectar.EjecutarDB("Insert Into Tareas(CodigoTarea,Fecha,Vence,IdSemestre,IdAsignatura,IdSeccion,Descripcion) values ('"+this.CodigoTarea+"', '"+this.Fecha.ToString("yyyy/MM/dd")+"','"+this.Vence.ToString("dddd/MM/dd")+"',"+this.IdSemestre+","+this.IdAsignatura+","+this.IdSeccion+","+this.Descripcion+") ");
       }

       public bool Modificar(int idm)
       {
           return conectar.EjecutarDB("Update Tareas set CodigoTarea ='"+this.CodigoTarea+"', Fecha ='"+this.Fecha.ToString("dddd/MM/dd")+"', Vence ='"+this.Vence.ToString("yyyy/MM/dd")+"', IdAsignatura= "+this.IdAsignatura+", IdSeccion = "+this.IdSeccion+", Descripcion = '"+this.Descripcion+"' where IdTarea = "+ idm);
       }

       public bool Eliminar(int ide)
       {
       return conectar.EjecutarDB("Delete From Tareas where IdTarea= "+ ide);
       }

       public DataTable Listar(string campo, string filtro) 
       {
           return conectar.BuscarDb("Select "+ campo +" from Tareas where IdTarea= "+ filtro);
       }

       public bool Buscar(int idb) 
       {
           DataTable dt = new DataTable();
           bool msj = false;

           dt = conectar.BuscarDb("select * from Tareas where IdTarea= "+ idb);
           if (dt.Rows.Count > 0) 
           {
               msj = true;
               this.CodigoTarea =(string)dt.Rows[0]["CodigoTarea"];
               this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
               this.Vence = (DateTime)dt.Rows[0]["Vence"];
               this.IdSemestre = (int)dt.Rows[0]["IdSemestre"];
               this.IdAsignatura= (int)dt.Rows[0]["IdAsignatura"];
               this.IdSeccion = (int)dt.Rows[0]["IdSeccion"];
               this.Descripcion = (string)dt.Rows[0]["Descripcion"];
      
           }
           return msj;
       }
    }
}
