using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double altura, peso, resultado = 0;

            if ( double.TryParse(maskedTextBox1.Text, out altura) && double.TryParse(maskedTextBox2.Text, out peso))
            {
                if (radioButton1.Checked)
                {
                    resultado = (72.7 * altura) - 58;
                }
                else if (radioButton2.Checked)
                {
                    resultado = (62.1 * altura) - 44.7;
                }

                resultado = Math.Round(resultado, 2);

                if (peso > resultado)
                { this.textBox1.Text = "Necessário Regime!"; }
                else if (peso == resultado)
                { this.textBox1.Text = "Peso Ideal"; }
                else
                { this.textBox1.Text = "Peso Baixo!"; }

                this.textBox2.Text = resultado.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os dados corretamente!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            this.maskedTextBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.maskedTextBox1.Clear();
            this.maskedTextBox2.Clear();
            this.textBox1.Clear();
            this.textBox2.Clear();

            this.maskedTextBox1.Focus();
        }
    }
}
