using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_promedio_Click(object sender, EventArgs e)
        {
            int nota1, nota2, nota3;

            bool esNota1 = int.TryParse(txb_nota1.Text, out nota1);
            bool esNota2 = int.TryParse(txb_nota2.Text, out nota2);
            bool esNota3 = int.TryParse(txb_nota3.Text, out nota3);

            if (esNota1 && esNota2 && esNota3)
            {
                int promedio = (nota1 + nota2 + nota3) / 3;
                txb_promedio.Text = promedio.ToString();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txb_nota1.Text = "";
            txb_nota2.Text = "";
            txb_nota3.Text = "";
            txb_promedio.Text = "";

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
