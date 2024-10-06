using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio12._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_semipe_Click(object sender, EventArgs e)
        {
            double lado1, lado2, lado3;

            bool esNumero1 = double.TryParse(txb_ladoA.Text, out lado1);
            bool esNumero2 = double.TryParse(txb_ladoB.Text, out lado2);
            bool esNumero3 = double.TryParse(txb_ladoC.Text, out lado3);

            if (esNumero1 && esNumero2 && esNumero3)
            {
                double semiperimetro = (lado1 + lado2 + lado3) / 2;
                txb_semipe.Text = semiperimetro.ToString();
            }
        }

        private void btn_area_Click(object sender, EventArgs e)
        {
            double lado1, lado2, lado3;

            bool esNumero1 = double.TryParse(txb_ladoA.Text, out lado1);
            bool esNumero2 = double.TryParse(txb_ladoB.Text, out lado2);
            bool esNumero3 = double.TryParse(txb_ladoC.Text, out lado3);

            if (esNumero1 && esNumero2 && esNumero3)
            {
                double semiperimetro = (lado1 + lado2 + lado3) / 2;
                double area = Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));
                
                txb_area.Text = area.ToString();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txb_ladoA.Text = "";
            txb_ladoB.Text = "";
            txb_ladoC.Text = "";
            txb_semipe.Text = "";
            txb_area.Text = "";
        }

        private void btn_salida_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
