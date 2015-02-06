using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace TeacherControl3
{
    public partial class RegistroUsuarios : System.Web.UI.Page
    {
        Usuarios usuario = new Usuarios();

        protected void Page_Load(object sender, EventArgs e)
        {
            MsjLabel.Text = "";
            if (!IsPostBack)
            {
                Session["Modificando"] = false;
            }

        }

        #region "Metodos"


        private void llenacampo()
        {
            IdTextBox.Text = Convert.ToString(IdTextBox.Text);

            NombreTextBox.Text = usuario.Nombre;
            ClaveTextBox.Text = usuario.Clave;
            EmailTextBox.Text = usuario.Email;
            ActivoTextBox.Text = Convert.ToString(ActivoTextBox.Text);

            if (usuario.Nombre !=null)
            {
                Session["Modificando"] = true;
            }
            else
            {
                Session["Modificando"] = false;
            }
        }
 
  
        private void llenaclase()
        {
            usuario.IdUsuario = Convert.ToInt32(IdTextBox.Text);
            usuario.Nombre = NombreTextBox.Text;
            usuario.Clave = ClaveTextBox.Text;
            usuario.Email = EmailTextBox.Text;
            usuario.esActivo = Convert.ToInt32(ActivoTextBox.Text);
        }

        private void limpiacampos()
        {
            IdTextBox.Enabled = true;
            Session["Modificando"] = false;
            IdTextBox.Text = "";
            NombreTextBox.Text = "";
            ClaveTextBox.Text = "";
            EmailTextBox.Text = "";
            ActivoTextBox.Text = "";

        }
      
        protected void ClearButton_Click(object sender, EventArgs e)
        {
            limpiacampos();
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            llenaclase();
            if (Convert.ToBoolean(Session["Modificando"]) == false)
            {
                if (usuario.Insertar() == true)
                {

                    MsjLabel.ForeColor = System.Drawing.Color.Green;
                    MsjLabel.Text = "Registro realizado con exito";
                    limpiacampos();
                }
                else
                {
                    MsjLabel.ForeColor = System.Drawing.Color.Red;
                    MsjLabel.Text = "Error de registro";
                }
            }
        }

        protected void DeleteButton_Click(object sender, EventArgs e)
        {
            if(usuario.Eliminar(IdTextBox.Text) == true)
            {
                MsjLabel.ForeColor = System.Drawing.Color.Green;
                MsjLabel.Text = "Usuario Eliminado Correctamente";
                limpiacampos();
            }
            else
            {
                MsjLabel.ForeColor = System.Drawing.Color.Red;
                MsjLabel.Text = "Seleccione el Usuario que desea eliminar";
            }
        }
       
    }
        #endregion "Metodos"
}