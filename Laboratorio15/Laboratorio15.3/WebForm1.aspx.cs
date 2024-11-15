using System;

namespace Laboratorio15._3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public WebForm1()
        {
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "¡Hola, " + TextBox1.Text + "!";
        }

    }
}
