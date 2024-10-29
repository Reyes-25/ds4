using System;

namespace Laboratorio15._3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            lblSaludo.Text = $"¡Hola, {nombre}! ¡Bienvenido!";

            // Mostrar alerta con JavaScript
            string script = $"window.alert('Hola: {nombre}');";
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Alert", script, true);
        }
    }
}
