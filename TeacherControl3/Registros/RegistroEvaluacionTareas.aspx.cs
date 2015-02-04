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
            Evaluacion.IdEstudiante = IdEstudianteTextBox.Text;
            Evaluacion.IdEvaluacion = IdEvaluacionTextBox.Text;
            Evaluacion.Fecha = Convert.ToDateTime(FechaTextBox.Text);
            Evaluacion.Calificacion = CalificacionTextBox.Text;
            Evaluacion.IdTarea = IdTareaTextBox.Text;


        }



        public void LlenarCampos(EvaluacionesTareas Evaluacion)
        {
            IdEstudianteTextBox.Text = Evaluacion.IdEstudiante;
            IdEvaluacionTextBox.Text = Evaluacion.IdEvaluacion;
            FechaTextBox.Text = Evaluacion.Fecha.ToString("yyyy-MM-dd");
            CalificacionTextBox.Text = Evaluacion.Calificacion;
            IdTareaTextBox.Text = Evaluacion.IdTarea;
            
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
            string IdProfesor = IdEvaluacionTextBox.Text;
            VaciarCampos();
            //MensajeLabel.Text = "Evaluacion con el Id " + IdEvaluacion + " fue Eliminado";
        }

        protected void EliminarButton_Click1(object sender, EventArgs e)
        {

        }



       
    }
}