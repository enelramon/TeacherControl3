using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
   public class Usuarios
    {
       public int IdUsuario { set; get; }
       public string Nombre { set; get; }
       public string Clave { set; get; }
       public string Email { set; get; }
       public int esActivo { set; get; }

       public ConexionDb conexion = new ConexionDb();

        public Usuarios()
        {
            this.IdUsuario = 0;
        }

       public bool Insertar()
       {
           bool accion = false;
           accion = conexion.EjecutarDB("Insert into Usuarios(Nombre,Clave,Email,esActivo) values('" + Nombre + "','" + Clave + "','" + Email + "','" + esActivo + "')");
           return accion;
       }
       
        public bool Modificar()
       {
           bool accion = false;
           accion = conexion.EjecutarDB("Update Usuarios set Nombre = '" + Nombre + "', Clave = '" + Clave + "', Email = '" + Email + "', esActivo = '" + esActivo + "' Where IdUsuario = " + IdUsuario.ToString());
           return accion;

       }

       public bool Eliminar(int prmIdUsuario)
       {
           bool accion = false;
           accion = conexion.EjecutarDB("Delete from Usuarios where IdUsuario = " + prmIdUsuario);
           return accion;
       }

       public bool Buscar(int prmUsuario)
       {
           bool Retorno = false;
           DataTable Datos = new DataTable();

           Datos = conexion.BuscarDb("Select * from Usuarios where IdUsuario = " + prmUsuario);
           if (Datos.Rows.Count > 0)
           {
               Retorno = true;
               this.IdUsuario = (int)Datos.Rows[0]["IdUsuario"];
               this.Nombre = (string)Datos.Rows[0]["Nombre"];
               this.Clave = (string)Datos.Rows[0]["Clave"];
               this.Email = (string)Datos.Rows[0]["Email"];
               this.esActivo = (int)Datos.Rows[0]["esActivo"];
           }

           return Retorno;
       }

       public DataTable Listar(string FiltroWhere)
       {
           DataTable datos = new DataTable();
           datos = conexion.BuscarDb("Select IdUsuario,Nombre,Email,esActivo from Usuarios Where " + FiltroWhere);
           return datos;
       }

       public bool BuscarId(string Nombre)
       {
            Boolean paso = false;
           DataTable Datos = new DataTable();
           Datos = conexion.BuscarDb("Select * from Nombre = '" + Nombre + "'");

           if (Datos.Rows.Count > 0)
           {
               this.IdUsuario = (int)Datos.Rows[0]["IdUsuario"];
                paso = true;
           }

            return paso;
       }

        public Boolean Autenticar(string pUserName, string pPassword)
        {
            Boolean retorno = false;
            object idUsuario = conexion.ObtenerValorDb("SELECT IdUsuario from Usuarios Where Usuarios = '" + pUserName + "' And Clave = '" + pPassword + "'");

            if (idUsuario != null)
       {
                retorno = this.Buscar((int)idUsuario);
            }

            return retorno;
       }

       public bool Eliminar(string p)
       {
           throw new NotImplementedException();
       }
    }
}
