using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TeacherControl3.Registros
{
    public partial class sumar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)
            //{
            //    OrigenLabel.Text = "Primera vez que se abre";
            //}
            //else
            //{
            //    OrigenLabel.Text = "recargando porque precionaron algo";
            //}
        }

        protected void SumarButton_Click(object sender, EventArgs e)
        {
            TotalLabel.Text = Num1TextBox.Text + Num2TextBox.Text;
        }
    }
}