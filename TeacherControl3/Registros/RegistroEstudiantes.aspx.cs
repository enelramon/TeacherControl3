using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeacherControl3.Registros
{
    public partial class RegistroEstudiantes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void SaveButton_Click(object sender, EventArgs e)
        {
 Estudiantes r = new Estudiantes();
            int IdRegistro = 0;
            int.TryParse(IdRegistroTextBox.Text, out IdRegistro);

            r.Nombres = NombresTextBox.Text;
            r.Apellidos = ApellidosTextBox.Text;
            r.Telefono = TelefonoTextBox.Text;
            r.Celular = CelularTextBox.Text;
            r.Direccion = DireccionTextBox.Text;
            r.Email = EmailTextBox.Text;
            // r.Fecha = FechaTextBox.Text; 


            if (r.Insertar())
            {



            }
        }

        protected void ClearButton_Click(object sender, EventArgs e)
        {
            LimpiarCampos();

        }

        public void LimpiarCampos()
        {
            this.IdRegistroTextBox.Text = "";
            this.NombresTextBox.Text = "";
            this.FechaTextBox.Text = "";
            this.ApellidosTextBox.Text = "";
            this.TelefonoTextBox.Text = "";
            this.CelularTextBox.Text = "";
            this.DireccionTextBox.Text = "";
            this.EmailTextBox.Text = "";
        }
        protected void DeleteButton_Click(object sender, EventArgs e)
        {

        }

        protected void ApellidosTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}