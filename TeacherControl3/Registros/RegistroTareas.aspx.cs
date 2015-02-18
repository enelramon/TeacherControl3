using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
namespace TeacherControl3
{
    public partial class RegistroTareas : System.Web.UI.Page
    {
        public void LLenarClase(Tareas tarea)
        {
            tarea.CodigoTarea = CodigotareaTextBox.Text;
            tarea.Fecha = Convert.ToDateTime( FechaTextBox.Text);
            tarea.Vence = Convert.ToDateTime(VenseTextBox.Text);
            tarea.IdSemestre = Convert.ToInt32(IdsemestreDropDownList.Text);
            tarea.IdAsignatura = Convert.ToInt32(IdasignaturaDropDownList.Text);
            tarea.Descripcion = DescripcionTextBox.Text;
        }

        public void LLenarCampos(Tareas tarea) 
        {
            IdtareaTextBox.Text = tarea.IdTarea.ToString();
            CodigotareaTextBox.Text = tarea.CodigoTarea.ToString();
            FechaTextBox.Text = tarea.Fecha.ToString("yyyy/MM/dd");
            VenseTextBox.Text = tarea.Vence.ToString("yyyy/MM/dd");
            IdsemestreDropDownList.Text = tarea.IdSemestre.ToString();
            IdasignaturaDropDownList.Text = tarea.IdSemestre.ToString();
            DescripcionTextBox.Text = tarea.Descripcion.ToString();          
            
        }

        public void VaciarCampos()
        {
            IdtareaTextBox.Text = "";
            CodigotareaTextBox.Text = "";
            FechaTextBox.Text = "";
            VenseTextBox.Text = "";
            IdsemestreDropDownList.Text = "";
            IdasignaturaDropDownList.Text = "";
            DescripcionTextBox.Text = "";
        
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Tareas tarea = new Tareas();
                if (Request.QueryString["IdTarea"] != null)
                {
                     IdtareaTextBox.Text = Request.QueryString["IdTarea"];

                    if(tarea.Buscar(Convert.ToInt32(IdtareaTextBox.Text))
                    this.LLenarCampos(tarea);
                    
                }
            }
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {

            if (Request.QueryString["IdTarea"] != null)
            {
                Tareas tarea = new Tareas();
                this.LLenarClase(tarea);
                tarea.Modificar(Convert.ToInt32(Request.QueryString["IdTarea"]));
            }
            else
            {
                Tareas tarea = new Tareas();
                this.LLenarClase(tarea);
                tarea.Insertar();
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Tareas tarea = new Tareas();
            if (tarea.Eliminar(Convert.ToInt32(Request.QueryString["IdTarea"])))
            {
                this.VaciarCampos();
            }

        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            this.VaciarCampos();
        }
    }
}