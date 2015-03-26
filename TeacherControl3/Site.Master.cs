using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL.Utilitarios;
namespace TeacherControl3
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Util.ObtenerEntero(Session["Nivel"]) != 0)
                UsuariosHyperLink.Visible = false;
        }
    }
}