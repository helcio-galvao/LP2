using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double num1, num2, result;
        Button operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResult.Text = "";
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Valida(object sender, EventArgs e)
        {
            if (double.TryParse(txtNum1.Text, out num1) && double.TryParse(txtNum2.Text, out num2))
            {
                operador = (Button)sender;
                switch (operador.Text)
                {
                    case "+":
                        OprAdd (num1, num2);
                        break;
                    case "-":
                        OprSub (num1, num2);
                        break;
                    case "*":
                        OprMult (num1, num2);
                        break;
                    case "/":
                        OprDiv (num1, num2);
                        break;

                    default:
                        MessageBox.Show("Operação inválida!!");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Numeros invalidos!!");
            }
        }

        private void OprAdd (double a, double b)
        {
            result = a + b;
            txtResult.Text = result.ToString();
        }

        private void OprSub(double a, double b)
        {
            result = a - b;
            txtResult.Text = result.ToString();
        }

        private void OprMult(double a, double b)
        {
            result = a * b;
            txtResult.Text = result.ToString();
        }
        private void OprDiv(double a, double b)
        {
            if (b != 0)
            {
                result = a / b;
                txtResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Erro: Impossível fazer divisão por zero!!");
            }
        }
    }
}
