using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using TeacherControl3;


namespace TeacherControl3.Registros
{
    public partial class RegistroEvaluacionTareas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public void LlenarClase(EvaluacionesTareas Evaluacion)
        {
            Evaluacion.IdEstudiante = Convert.ToInt32( IdEstudianteTextBox.Text);
            Evaluacion.IdEvaluacion = Convert.ToInt32(IdEvaluacionTextBox.Text);
            Evaluacion.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            Evaluacion.Calificacion = Convert.ToInt32(CalificacionTextBox.Text);
            Evaluacion.IdTarea = Convert.ToInt32(IdTareaTextBox.Text);

        }

        
        public void LlenarCampos(EvaluacionesTareas Evaluacion)
        {
            IdEstudianteTextBox.Text = Evaluacion.IdEstudiante.ToString();
            IdEvaluacionTextBox.Text = Evaluacion.IdEvaluacion.ToString();
            FechaTextBox.Text = Evaluacion.Fecha.ToString("yyyy-MM-dd");
            CalificacionTextBox.Text = Evaluacion.Calificacion.ToString();
            IdTareaTextBox.Text = Evaluacion.IdTarea.ToString();
            
        }

        public void VaciarCampos()
        {
            IdEstudianteTextBox.Text = "";
            IdEvaluacionTextBox.Text = "";
            FechaTextBox.Text = "";
            CalificacionTextBox.Text = "";
            IdTareaTextBox.Text = "";
           
        }

        public void BuscarEvaluacion()
        {
            EvaluacionesTareas Evaluacion = new EvaluacionesTareas();
            if (IdEvaluacionTextBox.Text == "")
            {
                VaciarCampos();
            }
            else
            {
                Evaluacion.Buscar(Convert.ToInt32(IdEvaluacionTextBox.Text.Trim()));
                LlenarCampos(Evaluacion);
            }
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            EvaluacionesTareas Evaluacion = new EvaluacionesTareas();
            LlenarClase(Evaluacion);
            Evaluacion.Insertar();
            //MensajeLabel.Text = "Guardado con Exito";
        }

    

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            //MensajeLabel.Text = "";
            BuscarEvaluacion();
        }
        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            //MensajeLabel.Text = "";
            VaciarCampos();
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            EvaluacionesTareas Evaluacion = new EvaluacionesTareas();
            Evaluacion.Eliminar(Convert.ToInt32(IdEvaluacionTextBox.Text.Trim()));

            VaciarCampos();
            //MensajeLabel.Text = "Evaluacion con el Id " + IdEvaluacion + " fue Eliminado";
        }

        protected void EliminarButton_Click1(object sender, EventArgs e)
        {

        }

        protected void VerEstudianteButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registros/RegistroEstudiantes.aspx?IdEstudiante=" + IdEstudianteTextBox.Text);
        }



       
    }
}