using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio15._4
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_sumar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(TextBox1.Text, out double numero1) && double.TryParse(TextBox2.Text, out double numero2))
            {
                double resultado = numero1 + numero2;

                lbl_resultado.Text = "Resultado: " + resultado;
            }
            else
            {
                lbl_resultado.Text = "Por favor, ingrese números válidos.";
            }
        }
    }
}
