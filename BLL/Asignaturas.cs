﻿using DAL;
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
            this.esActivo = true;
        }


        public bool Insertar()
        {
            ConexionDb conexiondb = new ConexionDb();
            bool accion = false;
            accion = conexiondb.EjecutarDB("Insert Into Asignaturas(Codigo, Nombre, Creditos, esActivo)Values('" + this.Codigo +
                "','" + this.Nombre + "','" + this.Creditos + "','" + this.esActivo + "')");

            if (accion)
            {
                IdAsignatura = (int)conexiondb.ObtenerValorDb("Select Max(IdAsignatura) from Asignaturas");
            }
            return accion;
        }

        public bool Eliminar(int IdAsignatura)
        {

            ConexionDb conexiondb = new ConexionDb();
            return conexiondb.EjecutarDB("Delete from Asignaturas where IdAsignatura = " + IdAsignatura.ToString());

        }

        public bool Modificar(int IdAsignatura)
        {
            ConexionDb conexiondb = new ConexionDb();
            return conexiondb.EjecutarDB("Update from Asignaturas set Nombre = '" + Nombre + "', Creditos = '" + Creditos + "', Codigo ='" + Codigo + "', esActvo ='" + esActivo + "' where IdAsignatura= " + IdAsignatura);
        }

        public bool Buscar(int IdAsignatura)
        {
            ConexionDb conexiondb = new ConexionDb();
            bool mensaje = false;
            DataTable dt = new DataTable();
            dt = conexiondb.BuscarDb("Select *From Asignaturas where IdAsignatura =" + IdAsignatura);
            if (dt.Rows.Count > 0)
            {
                mensaje = true;
                this.Nombre = (string)dt.Rows[0]["Nombre"];
                this.Creditos = (int)dt.Rows[0]["Creditos"];
                this.Codigo = (int)dt.Rows[0]["Codigo"];

            }
            return mensaje;
        }

        public static DataTable Lista(String Campo, String FiltroWhere)
        {

            ConexionDb conexiondb = new ConexionDb();
            return conexiondb.BuscarDb("Select " + Campo + " from Asignaturas " + FiltroWhere);

        }

    }

}

