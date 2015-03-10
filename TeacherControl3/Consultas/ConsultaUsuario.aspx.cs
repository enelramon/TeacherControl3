using System;
using System.Web;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using BLL;

namespace TeacherControl3.Consultas
{
    public partial class ConsultaUsuario : System.Web.UI.Page
    {
        Usuarios usuario = new Usuarios();
        string Campos = "IdUsuario,Nombre,Email,esActivo";
        string Filtro = "1=1";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BuscarGridView.DataSource = usuario.Listar(Campos, Filtro);
                BuscarGridView.DataBind();
            }
        }

        protected void BuscarButton_Click(object sender, EventArgs e)
        {
            if (BuscarDropDownList.SelectedIndex == 0)
            {
                Campos += "and Id like '%" + BuscarTextBox.Text + "%'";
            }
            if (BuscarDropDownList.SelectedIndex == 1)
            {
                Campos += "and Nombre like '%'"+ BuscarTextBox.Text + "%'";
            }
            BuscarGridView.DataSource = usuario.Listar(Campos, Filtro);
            BuscarGridView.DataBind();
        }

    }
}