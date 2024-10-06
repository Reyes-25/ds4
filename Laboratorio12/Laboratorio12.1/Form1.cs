using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void b_veloc_Click(object sender, EventArgs e)
        {
            double velocidad, tiempo;

            bool velocidadValida = double.TryParse(tb_veloc.Text, out velocidad);
            bool tiempoValido = double.TryParse(tb_tiemp.Text, out tiempo);

            if (velocidadValida && tiempoValido)
            {
                double distancia = velocidad * tiempo;
                tb_distan.Text = distancia.ToString();
            }
            else
            {
                tb_distan.Text = "ERROR";
            }

        }

        private void b_limp_Click(object sender, EventArgs e)
        {
            tb_veloc.Text = "";
            tb_tiemp.Text = "";
            tb_distan.Text = "";
        }

        private void b_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
