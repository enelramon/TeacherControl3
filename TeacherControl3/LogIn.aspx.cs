using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace TeacherControl3
{
    public partial class LogIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EntrarButton_Click(object sender, EventArgs e)
        {

            Usuarios Usuario = new Usuarios();
            Session["Nivel"] = -1;

            if (Usuario.Autenticar(UsuarioTextBox.Text, ClaveTextBox.Text))
            {
                FormsAuthentication.RedirectFromLoginPage(UsuarioTextBox.Text, true);
                 Session["Nivel"] = Usuario.Nivel;
            }
            else
                ErrorLabel.Text = "Usuario y clave no existen";
        }
    }
}