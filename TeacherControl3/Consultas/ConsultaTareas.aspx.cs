using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeacherControl3.Consultas
{
    public partial class ConsultaTareas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                consultatareasGridView.DataSource = Tareas.Listar("*", "1=1");
                consultatareasGridView.DataBind();
            }
        }

        protected void buscarButton_Click(object sender, EventArgs e)
        {
           

            if (buscarDropDownList.SelectedIndex == 0)
            {

                consultatareasGridView.DataSource = Tareas.Listar("*", "CodigoTarea like '" + buscarTextBox.Text + "%'");
                consultatareasGridView.DataBind();
            }
            if (buscarDropDownList.SelectedIndex == 1)
            {
                consultatareasGridView.DataSource = Tareas.Listar("*", "Descripcion  like '" + buscarTextBox.Text + "%'");
                consultatareasGridView.DataBind();
            }  
        }
    }
}