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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GuardarButton_Click(object sender, EventArgs e)
        {

            Asignaturas a = new Asignaturas();
            int IdAsignatura = 0;
            int.TryParse(IdAsignaturaTextBox.Text, out IdAsignatura);

            a.Nombre = NombreTextBox.Text;
            a.Creditos = CreditosTextBox.Text;
            a.Codigo = CodigoTextBox.Text;




            if (a.Insertar())
            {



            }

        }


        public void LimpiarCampos()
        {
            this.IdAsignaturaTextBox.Text = "";
            this.NombreTextBox.Text = "";
            this.CodigoTextBox.Text = "";
            this.CreditosTextBox.Text = "";

        }

        protected void EliminarButton_Click(object sender, EventArgs e)
        {
            Asignaturas a = new Asignaturas();
            a.Eliminar(Convert.ToInt32(IdAsignaturaTextBox.Text.Trim()));

            LimpiarCampos();
        }

        protected void NuevoButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}