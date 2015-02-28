using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace TeacherControl3
{
    public partial class ConsultaEvaluacion : System.Web.UI.Page
    {
        EvaluacionesTareas Evaluacion = new EvaluacionesTareas();
        string campos = "IdEstudiante, IdTarea  CONVERT((varchar, IdEstudiante,105) as IdEstudiante, CONVERT(varchar, IdEvaluacion,105) as IdEvaluacion, CONVERT(Varchar, Calificacion, 105) as Calificacion, CONVERT(Varchar, IdTarea, 105) as IdTarea, CONVERT(Varchar, Fecha, 105) as Fecha";
        String filtro = "1=1";     
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                ConsultaGridView.DataSource = Evaluacion.Listar("IdEstudiante, IdTarea, IdFecha, IdEvaluacion Calificacion","1=1","IdEstudiante");
                ConsultaGridView.DataBind();

            }


        }


        protected void Button1_Click(object sender, EventArgs e)
        {


            if (ConsultaDropDownList.SelectedIndex == 0)
            {
                filtro += "and Id like '%" + ConsultaTextBox.Text + "%'";
            }
            ConsultaGridView.DataSource = Evaluacion.Listar(campos, filtro , "IdEstudiante ");
            ConsultaGridView.DataBind();


        }

        protected void ConsultaDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}