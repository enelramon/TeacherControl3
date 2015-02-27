using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace TeacherControl3.Registros
{
    public partial class RegistroAsignatura : System.Web.UI.Page
    {

          public void LLenarClase(Asignaturas asignatura)
        {
            asignatura.Codigo = Convert.ToInt32(CodigoTextBox.Text);
            asignatura.Nombre = NombreTextBox.Text;
            asignatura.Creditos = Convert.ToInt32(CreditosTextBox.Text);
            asignatura.esActivo = Activo.Checked;
         }

          private void LlenarCampos(Asignaturas asignatura)
          {

              IdAsignaturaTextBox.Text = Convert.ToString(IdAsignaturaTextBox.Text);
              NombreTextBox.Text = asignatura.Nombre;
              CreditosTextBox.Text = asignatura.Creditos.ToString();
              CodigoTextBox.Text = asignatura.Codigo.ToString();
              Activo.Checked = asignatura.esActivo;


          }


        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {
            Asignaturas asignatura = new Asignaturas();
            this.LLenarClase(asignatura);
            asignatura.Insertar();
        }


        public void LimpiarCampos()
        {
            this.IdAsignaturaTextBox.Text = "";
            this.NombreTextBox.Text = "";
            this.CodigoTextBox.Text = "";
            this.CreditosTextBox.Text = "";
            this.Activo.Text = "";

        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Asignaturas asignatura = new Asignaturas();
            asignatura.Eliminar(Convert.ToInt32(IdAsignaturaTextBox.Text.Trim()));

            LimpiarCampos();
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}