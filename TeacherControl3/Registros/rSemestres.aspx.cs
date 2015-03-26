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
        Semestres semestre = new Semestres();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //Session["Modificando"] = false;
                int IdSemestre = 0;

                IdSemestre = Util.ObtenerEntero(Request.QueryString["IdSemestre"]);
                semestre.IdSemestre = IdSemestre;
                if (IdSemestre != 0)
                {
                    ClearButton.Visible = true;
                    SaveButton.Visible = true;
                    IdSemestreTextBox.Visible = true;
                    IdSemestreTextBox.Text = IdSemestre.ToString();
                }

                if (semestre.Buscar())
                {
                    LlenaCampo(semestre);
                }
            }
        }

        #region
        private void LlenaCampo(Semestres semestre)
        {
            IdSemestreTextBox.Text = Convert.ToString(IdSemestreTextBox.Text);
            CodigoTextBox.Text = semestre.Codigo;
            FechaInicio.Text = semestre.FechaInicio.ToString("yyyy-MM-dd");
            FechaFin0.Text = semestre.FechaFin.ToString("yyyy-MM-dd");
            FechaParcial1.Text = semestre.FechaInicio.ToString("yyyy-MM-dd");
            FechaParcial2.Text = semestre.FechaParcial1.ToString("yyyy-MM-dd");
            FechaFinal.Text = semestre.FechaFinal.ToString("yyyy-MM-dd");
            esActivoCheckBox.Checked = semestre.esActivo;

            //if (semestre.Codigo != null)
            //{
            //    Session["Modificando"] = true;
            //}
            //else
            //{
            //    Session["Modificando"] = false;
            //}
        }

        private void LlenaClase()
        {
            semestre.Codigo = CodigoTextBox.Text;
            semestre.FechaInicio = DateTime.Parse(FechaInicioTextBox.Text);
            semestre.FechaFin = DateTime.Parse(FechaFinTextBox.Text);
            semestre.FechaParcial1 = DateTime.Parse(FechaParcial1TextBox.Text);
            semestre.FechaParcial2 = DateTime.Parse(FechaParcial2TextBox.Text);
            semestre.FechaFinal = DateTime.Parse(FechaFinalTextBox.Text);
            semestre.esActivo = esActivoCheckBox.Checked;
            
        }


        private void LimpiarCampos()
        {
            IdSemestreTextBox.Enabled = true;
            Session["Modificando"] = false;
            CodigoTextBox.Text = "";
            FechaInicioTextBox.Text = "";
            FechaFinTextBox.Text = "";
            FechaParcial1TextBox.Text = "";
            FechaParcial2TextBox.Text = "";
            FechaFinalTextBox.Text = "";
        }


        protected void SaveButton_Click(object sender, EventArgs e)
        {


            Semestres semestre = new Semestres();
            LlenaClase();
            //if (Convert.ToBoolean(Session["Modificando"]) == false)
            //{

            if (Request.QueryString["IdSemestre"] != null)
            {
                semestre.IdSemestre = int.Parse(Request.QueryString["IdSemestre"]);

                    if (semestre.Modificar())
                    {
                        Response.Redirect("cSemestres.aspx");
                    }
                    else
                    {
                        Response.Write("No se pudo modificar");
                    }
            }
            else
                if (semestre.Insertar())
                {

                    LimpiarCampos();
                    Response.Write("Registro realizado con exito");
                }

                else
                {
                    Response.Write("Error de registro");
                }


        //}
      

            
        }



        protected void ClearButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        protected void esActivoCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            Semestres semestre = new Semestres();
            if (semestre.Eliminar(IdSemestreTextBox.Text) == true)
            {
                Response.Write("Semestre Eliminado");
                LimpiarCampos();
            }
            else
            {
                Response.Write("Selecione el semestre que decea eliminar");
            }
        }






    }
        #endregion "metodos"

}