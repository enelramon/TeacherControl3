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
    public partial class RegistroTareas : System.Web.UI.Page
    {
        public void LLenarClase(Tareas tarea)
        {
            tarea.CodigoTarea = CodigotareaTextBox.Text;
            tarea.Fecha = Convert.ToDateTime(FechaTextBox.Text);
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
            Semestres semestre = new Semestres();
            Asignaturas asignatura = new Asignaturas();

            if (!IsPostBack)
            {
                Tareas tarea = new Tareas();
                if (Request.QueryString["IdTarea"] != null)
                {
                    tarea.IdTarea = Util.ObtenerEntero(Request.QueryString["IdTarea"]);
                    if (tarea.Buscar())
                        this.LLenarCampos(tarea);

                }
            }

            this.IdsemestreDropDownList.DataSource = semestre.Listar("IdSemestre,Codigo", "1=1");
            this.IdsemestreDropDownList.DataValueField = "IdSemestre";
            this.IdsemestreDropDownList.DataTextField = "Codigo";
            this.IdsemestreDropDownList.DataBind();

            this.IdasignaturaDropDownList.DataSource= Asignaturas.Lista("IdAsignatura,Nombre","1=1");
            this.IdasignaturaDropDownList.DataValueField = "IdAsignatura";
            this.IdasignaturaDropDownList.DataTextField = "Nombre";
            this.IdasignaturaDropDownList.DataBind();

        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {

            Tareas tarea = new Tareas();
            this.LLenarClase(tarea);


            if (Request.QueryString["IdTarea"] != null)
            {
                tarea.IdTarea = Util.ObtenerEntero(this.IdtareaTextBox.Text);
                tarea.Modificar();
                mensajeLabel.Text = "El registro se ha Modificado Correctamente";
            }
            else
            {
                tarea.Insertar();
                mensajeLabel.Text = "El registro se ha Guardado Correctamente";
            }
        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Tareas.Eliminar(Util.ObtenerEntero(this.IdtareaTextBox.Text));
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