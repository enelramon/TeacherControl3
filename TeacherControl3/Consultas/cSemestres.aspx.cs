using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace TeacherControl3.Consultas
{
    public partial class cSemestres : System.Web.UI.Page
    {
        Semestres semestre = new Semestres();
        string campos = "IdSemestre, Codigo, CONVERT(varchar, FechaInicio,105) as FechaInicio, CONVERT(varchar, FechaFin,105) as FechaFin, CONVERT(Varchar, FechaParcial1, 105) as FechaParcial1, CONVERT(Varchar, FechaParcial2, 105) as FechaParcial2, CONVERT(Varchar, FechaFinal, 105) as FechaFinal, esActivo";
        string filtro = "1=1";

        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
           {
               BuscarGridView.DataSource = semestre.Listar(campos, filtro);
               BuscarGridView.DataBind();
           }

        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (BuscarDropDownList.SelectedIndex == 0)
            {
                filtro += "and Codigo like '%" + BuscarTextBox.Text + "%'";
            }
            BuscarGridView.DataSource = semestre.Listar(campos, filtro);
            BuscarGridView.DataBind();
        }

        
    }
}