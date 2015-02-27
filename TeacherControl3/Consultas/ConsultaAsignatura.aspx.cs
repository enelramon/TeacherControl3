using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeacherControl3.Consultas
{
    public partial class ConsultaAsignatura : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.ConsultaGridView.DataSource = Estudiantes.Lista("*", "");
            this.ConsultaGridView.DataBind();
        }

        protected void BuscarButton_Click1(object sender, EventArgs e)
        {
            string Filtro = "1 = 1";

            if (BuscarDropDownList.SelectedIndex == 0)
            {
                Filtro = "d join Estudiantes p on d.IdRegistro = p.IdRegistro where p.IdRegistro like '" + BuscarText.Text + "%'";

            }

            if (BuscarDropDownList.SelectedIndex == 1)
            {
                Filtro = "d join Estudiantes p on d.IdRegistro = p.IdRegistro where p.Nombres like '" + BuscarText.Text + "%'";
            }
            ConsultaGridView.DataSource = Estudiantes.Lista("d.IdRegistro, d.Apellidos, d.Telefono, d.Celular ", Filtro);
 
        }


    }
}