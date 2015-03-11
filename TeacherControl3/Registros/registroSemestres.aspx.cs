using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace TeacherControl3.Registros
{
    public partial class registroSemestres : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Semestres sem = new Semestres();
            llenaClase(sem);

            if (sem.Insertar())
            {
                Response.Redirect("~/Consultas/cSemestres.aspx");
            }
            else
            {
                Response.Write("Error!!!");
            }
        }

        private void llenaClase(Semestres sem)
        {
            sem.Codigo = CodigoTextBox.Text;
            sem.FechaInicio = DateTime.Parse(FechaInicioTextBox.Text);
            sem.FechaFin = DateTime.Parse(FechaFinTextBox.Text);
            sem.FechaParcial1 = DateTime.Parse(FechaParcial1TextBox.Text);
            sem.FechaParcial2 = DateTime.Parse(FechaParcial2TextBox.Text);
            sem.FechaFinal = DateTime.Parse(FechaFinalTextBox.Text);
            sem.esActivo = esActivoCheckBox.Checked;
        }


    }
}