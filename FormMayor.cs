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
    public partial class FormMayor : Form
    {
        public FormMayor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double n1, n2;
            string resultado;

            n1 = double.Parse(txtNumero1.Text);
            n2 = double.Parse(txtNumero2.Text);

            if (n1 > n2)
            {
                resultado = "Numero 1 es mayor que numero 2";
                txtResultado.Text = resultado;
            }
            else if (n2 > n1)
            {
                resultado = "Numero 2 es mayor que numero 1";
                txtResultado.Text = resultado;
            }
            else if (n2.Equals(n1))
            {
                resultado = "Numero 1 es igual que numero 2";
                txtResultado.Text = resultado;
            }
            else
            {
                MessageBox.Show("No se realiza la operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = " ";
            txtNumero2.Text = " ";
            txtResultado.Text = " ";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
