using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora2
{
    public partial class Form1 : Form
    {
        private double valor1;
        private double valor2;

        private double resultado = 0;

        private int operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            //numero 0
            txtDisplay.Text = txtDisplay.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            //numero 1
            txtDisplay.Text = txtDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //numero 2
            txtDisplay.Text = txtDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            //numero 3
            txtDisplay.Text = txtDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //numero 4
            txtDisplay.Text = txtDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            //numero 5
            txtDisplay.Text = txtDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            //numero 6
            txtDisplay.Text = txtDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            //numero 7
            txtDisplay.Text = txtDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            //numero 8
            txtDisplay.Text = txtDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            //numero 9
            txtDisplay.Text = txtDisplay.Text + "9";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar
            txtDisplay.Text = "";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            // boton Suma
            operacion = 1;
            valor1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            // boton RESTA
            operacion = 2;
            valor1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            // boton IGUAL  
            valor2 = Convert.ToDouble(txtDisplay.Text);

            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    if (valor1 != 0 && valor2 != 0)
                    {
                        resultado = valor1 / valor2;
                    }
                    else 
                        MessageBox.Show("No se puede dividir por cero");
                    
                    break;
            }

            txtDisplay.Text = resultado.ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            // boton MULTIPLICACION

            operacion = 3;

            valor1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void btnDivicion_Click(object sender, EventArgs e)
        {
            // boton DIVISION
            operacion = 4;
            valor1 = Convert.ToDouble(txtDisplay.Text);
            txtDisplay.Text = "";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            // boton Punto

            txtDisplay.Text = txtDisplay.Text + ",";
        }
    }
}
