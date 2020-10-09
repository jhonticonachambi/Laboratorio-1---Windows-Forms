using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio1_Windows_Ticona
{
    public partial class FormSuma : Form
    {
        public FormSuma()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            //declarar variables 
            double n1, n2, resultado;

            //igualar las variables y realizar la conversion 
            n1 = double.Parse(txtNumero1.Text);
            n2 = double.Parse(txtNumero2.Text);

            //realizar calculo
            resultado = n1 + n2;

            //imprimir en caja de texto 
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = " ";
            txtNumero2.Text = " ";
            txtResultado.Text = " ";
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
