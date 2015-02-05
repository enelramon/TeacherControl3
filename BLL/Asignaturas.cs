using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Asignaturas
    {
        public int IdAsignatura { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Creditos { get; set; }
        public Boolean esActivo {get;set;}
        public Boolean esActivo { get; set; }

        public Asignaturas(int Codigo, string Nombre, int Creditos, Boolean esActivo)
        {
            this.Codigo = Codigo;
            this.Nombre = Nombre;
            this.Creditos = Creditos;
            this.esActivo = esActivo;

        }

         public Asignaturas()
        {
            IdAsignatura = 0;
            this.Nombre = "";
            this.Creditos = 0;
            this.Codigo = 0;
            this.esActivo = "";
        }

         ConexionDb conexiondb = new ConexionDb();

         public bool Insertar()
         {

             return conexiondb.EjecutarDB("Insert Into Asignaturas(Nombre, Creditos, Codigo, esActivo)Values('" + this.Nombre +
                 "','" + this.Creditos + "','" + this.Codigo + "','" + this.esActivo + "')");
         }

         public bool Eliminar(int IdAsignatura)
         {

             return conexiondb.EjecutarDB("Delete from Asignaturas where IdAsignatura = " + IdAsignatura.ToString());

         }

         public bool Modificar(int IdAsignatura)
         {
            
             return conexiondb.EjecutarDB("Update from Asignaturas set Nombre = '" + Nombre + "', Creditos = '" + Creditos + "', Codigo ='" + Codigo + "', esActvo ='" + esActivo +  "' where IdAsignaturas= " + IdAsignatura);
         }

         public bool Buscar(int IdAsignatura)
         {
             bool mensaje = false;
             DataTable dt = new DataTable();
             dt = conexiondb.BuscarDb("Select *From Asignaturas where IdAsignatura =" + IdAsignatura);
             if (dt.Rows.Count > 0)
             {
                 mensaje = true;
                 this.Nombre = (string)dt.Rows[0]["Nombre"];
                 this.Creditos = (int)dt.Rows[0]["Creditos"];
                 this.Codigo= (int)dt.Rows[0]["Codigo"];
               
             }
             return mensaje;
         }

    }


    }

