using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace celsius_para_fahrenheit
{
    public partial class Form1 : Form
    {
        double resultado = 0;
        void Converter(double num1)
        {
            resultado = (num1 * 1.8) + 32;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtN1.Text);

            Converter(num1);
            txtResultado.Text = resultado.ToString();
        }
    }
}
