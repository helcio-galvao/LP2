using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade3
{
    public partial class Form1 : Form
    {
        double Altura, Peso, Ideal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtAltura.Text, out Altura) && double.TryParse(txtPeso.Text, out Peso))
            {
                if (rbtHomem.Checked)
                {
                    Ideal = (72.7 * Altura) - 58;
                }
                else
                {
                    Ideal = (62.1 * Altura) - 44.7;
                }

                Ideal = Math.Round(Ideal, 2);

                if (Peso > Ideal)
                {
                    MessageBox.Show("Regime Obrigatório Já!!");
                }
                else if (Peso == Ideal)
                {
                    MessageBox.Show("Você está com o peso ideal.");
                }
                else
                {
                    MessageBox.Show("Coma bastante massas e doces!");
                }
            }
            else
            {
                MessageBox.Show("Dados de entrada inválidos!!");
            }
        }
    }
}
