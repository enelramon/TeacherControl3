using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using BLL.Utilitarios;

namespace TeacherControl3.Registros
{
    public partial class rSemestres : System.Web.UI.Page
    {
        Semestres semestres = new Semestres();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int IdSemestre = 0;

                IdSemestre =Util.ObtenerEntero(Request.QueryString["IdSemestre"]);

                if (IdSemestre != 0)
                {
                    ClearButton.Visible = true;
                    SaveButton.Visible = true;

                    IdSemestreTextBox.Visible = true;

                    IdSemestreTextBox.Text = IdSemestre.ToString();
                   

                }

                if (semestres.Buscar())
                {
                    CodigoTextBox.Text = semestres.Codigo;
                    FechaInicio.Text = semestres.FechaInicio.ToString("yyyy-MM-dd");
                    FechaFin0.Text = semestres.FechaFin.ToString("yyyy-MM-dd");
                    FechaParcial1.Text = semestres.FechaInicio.ToString("yyyy-MM-dd");
                    FechaParcial2.Text = semestres.FechaParcial1.ToString("yyyy-MM-dd");
                    FechaFinal.Text = semestres.FechaFinal.ToString("yyyy-MM-dd");
                    esActivoCheckBox.Checked = semestres.esActivo;
                }
            }
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            semestres.Codigo = CodigoTextBox.Text;
            semestres.FechaInicio = DateTime.Parse(FechaInicioTextBox.Text);
            semestres.FechaFin = DateTime.Parse(FechaFinTextBox.Text);
            semestres.FechaParcial1 = DateTime.Parse(FechaParcial1TextBox.Text);
            semestres.FechaParcial2 = DateTime.Parse(FechaParcial2TextBox.Text);
            semestres.FechaFinal = DateTime.Parse(FechaFinalTextBox.Text);
            semestres.esActivo = esActivoCheckBox.Checked;

            if (Request.QueryString["IdSemestre"] != null)
            {
                semestres.IdSemestre = int.Parse(Request.QueryString["IdSemestre"]);
                if (semestres.Modificar())
                {
                    Response.Redirect("cSemestres.aspx");
                }
                else
                {
                    Response.Write("No se pudo modificar");
                }
            }
            else
            {
                if (semestres.Insertar())
                {
                    Limpiar();
                    Response.Write("Se ha Guardado correctamente");
                }

            }

        }






        private void Limpiar()
        {
            Response.Redirect("rSemestres.aspx");
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        protected void esActivoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }


    }


}