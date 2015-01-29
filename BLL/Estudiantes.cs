using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Estudiantes
    {
        public int IdRegistro { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public DateTime Fecha { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }



        public Estudiantes(string Nombres,string Apellidos, string Telefono, string Celular, DateTime Fecha, string Direccion, string Email)
        {
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.Telefono = Telefono;
            this.Celular = Celular;
            this.Direccion = Direccion;
            this.Email = Email;
        }

        public Estudiantes()
        {
            IdRegistro = 0;
            this.Nombres = "";
            Fecha = DateTime.Now;
            this.Apellidos = "";
            this.Telefono = "";
            this.Celular = "";
            this.Direccion = "";
            this.Email = "";
        }

        ConexionDb conexiondb = new ConexionDb();

        public bool Insertar()
        {

        return conexiondb.EjecutarDB("Insert Into Estudiantes(Nombres,Apellidos,Telefono, Celular,Fecha, Direccion, Email)Values('" + this.Nombres +
            "','" + this.Apellidos + "','" + this.Telefono + "','" + this.Celular + "','" + this.Fecha.ToString("MM/dd/yyyy HH:mm:ss") + "','"+ this.Direccion + "','" + this.Email + "')");
        }

        public bool Eliminar(int IdRegistro)
        {
            
            return conexiondb.EjecutarDB("Delete from Estudiantes where IdRegistro = " + IdRegistro.ToString());

        }

        public bool Modificar(int IdRegistro)
        {
            return conexiondb.EjecutarDB("Update from Estudiantes set Nombres = '" + Nombres + "', Apellidos = '" + Apellidos + "', Telefono ='" + Telefono + "', Celular ='" + Celular + "', Direccion ='" + Direccion + "' , Email ='" + Email + "' where Estudiantes= " + IdRegistro);
        }


        public bool Buscar(int IdRegistro)
        {
            bool mensaje = false;
            DataTable dt = new DataTable();
            dt = conexiondb.BuscarDb("Select *From Estudiantes where IdRegistro =" + IdRegistro);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;
                this.Nombres = (string)dt.Rows[0]["Nombres"];
                this.Apellidos = (string)dt.Rows[0]["Apellidos"];
                this.Telefono = (string)dt.Rows[0]["Telefono"];
                this.Celular = (string)dt.Rows[0]["Celular"];
                this.Fecha = (DateTime)dt.Rows[0]["Fecha"];
                this.Direccion = (string)dt.Rows[0]["Direccion"];
                this.Email = (string)dt.Rows[0]["Email"];
                

            }
            return mensaje;
        }

        public static DataTable Lista(String Campo, String FiltroWhere)
        {

            ConexionDb conexiondb = new ConexionDb();
            return conexiondb.BuscarDb("Select " + Campo + " from Estudiantes " + FiltroWhere);

        }


    }

}
