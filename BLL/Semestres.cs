using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class Semestres
    {
       
        DataTable dt = new DataTable();
        public int IdSemestre { set; get; }
        public string Codigo { set; get; }
        public DateTime FechaInicio { set; get; }
        public DateTime FechaFin { set; get; }
        public DateTime FechaParcial1 { set; get; }
        public DateTime FechaParcial2 { set; get; }
        public DateTime FechaFinal { set; get; }
        public bool esActivo { set; get; }

        ConexionDb conexion = new ConexionDb();

        public bool Insertar()
        {
            bool paso = false;
            paso = conexion.EjecutarDB("Insert into Semestres (Codigo, FechaInicio, FechaFin, FechaParcial1, FechaParcial2, FechaFinal, esActivo) Values ('" + Codigo + "', '" + FechaInicio.ToString("MM/dd/yyyy") + "', '" + FechaFin.ToString("MM/dd/yyyy") + "', '" + FechaParcial1.ToString("MM/dd/yyyy") +
                "','" + FechaParcial2.ToString("MM/dd/yyyy") + "', '" + FechaFinal.ToString("MM/dd/yyyy") + "' , '" + esActivo + "' )");

            if (paso)
            {
                IdSemestre = (int)conexion.ObtenerValorDb("Select Max(IdSemestre) from Semestres");
            }
            return paso;
        }

        public bool Eliminar()//poner estatico
        {
            return conexion.EjecutarDB("Delete From Semestres Where IdSemestre = " + IdSemestre);
        }

        public bool Modificar()
        {
            return conexion.EjecutarDB("Update Semestres set Codigo = " + Codigo + "', FechaInicio ='" + FechaInicio.ToString("dd/MM//yyyy") + "', FechaInicio ='" + FechaFin.ToString("dd/MM//yyyy") + "', FechaParcial1 ='" + FechaParcial1.ToString("dd/MM//yyyy") + "', FechaParcial2 ='" + FechaParcial2.ToString("dd/MM//yyyy") + "', FechaFinal ='" + FechaFinal.ToString("dd/MM//yyyy") + "' where IdEstudiante= " + IdSemestre);
        }


        public bool Buscar()
        {
            bool retorno = false;
            dt = conexion.BuscarDb("Select * from Semestres where IdSemestre =" + IdSemestre);
            if (dt.Rows.Count > 0)
            {
                retorno = true;
                IdSemestre = (int)dt.Rows[0]["IdSemestre"];
                Codigo = (string)dt.Rows[0]["Codigo"];
                FechaInicio = (DateTime)dt.Rows[0]["FechaInicio"];
                FechaFin = (DateTime)dt.Rows[0]["FechaFin"];
                FechaParcial1 = (DateTime)dt.Rows[0]["FechaParcial1"];
                FechaParcial2 = (DateTime)dt.Rows[0]["FechaParcial2"];
                FechaFinal = (DateTime)dt.Rows[0]["FechaFinal"];
                esActivo = (bool)dt.Rows[0]["esActivo"];
            }
            return retorno;
        }
        public DataTable Listar(string campos, string filtro)
        {
            return conexion.BuscarDb("Select " + campos + " from Semestres where " + filtro);
        }



    }
}


