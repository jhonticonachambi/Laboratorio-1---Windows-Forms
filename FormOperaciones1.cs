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
    
    public partial class FormOperaciones1 : Form
    {
        double resultado;
        public FormOperaciones1()
        {
            InitializeComponent();
            lisOperaciones.Items.Add("Suma");
            lisOperaciones.Items.Add("Resta");
            lisOperaciones.Items.Add("Multiplicacion");
            lisOperaciones.Items.Add("Division");
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            //declarar variables 
            double n1, n2;

            //igualar las variables y realizar la conversion 
            n1 = double.Parse(txtNumero1.Text);
            n2 = double.Parse(txtNumero2.Text);

            //realizar calculo
            if (lisOperaciones.SelectedItem == "Suma")
            {
                resultado = n1 + n2;
            }

            else if (lisOperaciones.SelectedItem == "Resta")
            {
                resultado = n1 - n2;
            }

            else if (lisOperaciones.SelectedItem == "Multiplicacion")
            {
                resultado = n1 * n2;
            }

            else
            {
                if (n2 != 0)
                {
                    resultado = n1 / n2;
                }
                else
                {
                    MessageBox.Show("El valor del numero 2 debe ser distinto de cero ...", "Operaciones Aritmetica", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }


            //imprimir en caja de texto 
            txtResultado.Text = Convert.ToString(resultado);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = " ";
            txtNumero2.Text = " ";
            txtResultado.Text = " ";
        }
    }
}
