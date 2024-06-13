using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PCalculadora
{
    public partial class Form1 : Form
    {
        double v1, v2, res; // Variáveis que serão necessárias;

        public Form1()
        {
            InitializeComponent();
        }

        //Função que determina se os campos estão preenchidos com apenas números:
        static bool valido(string txt1, string txt2) 
        {
            double teste;

            if ( double.TryParse(txt1, out teste) && double.TryParse(txt2, out teste) )
                return true;
            else
                return false;
        }

        private void button3_Click(object sender, EventArgs e) //Adição:
        {

            if (valido(textBox1.Text, textBox2.Text))
            {
                v1 = Convert.ToDouble(textBox1.Text);
                v2 = Convert.ToDouble(textBox2.Text);
                res = v1 + v2;

                textBox3.Text = res.ToString();
            }
            else
                MessageBox.Show("Preencha os dois campos com dados númericos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button4_Click(object sender, EventArgs e) //Subtração:
        {
            if (valido(textBox1.Text, textBox2.Text))
            {
                v1 = Convert.ToDouble(textBox1.Text);
                v2 = Convert.ToDouble(textBox2.Text);
                res = v1 - v2;

                textBox3.Text = res.ToString();
            }
            else
                MessageBox.Show("Preencha os dois campos com dados númericos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button5_Click(object sender, EventArgs e) //Multipicação:
        {
            if (valido(textBox1.Text, textBox2.Text))
            {
                v1 = Convert.ToDouble(textBox1.Text);
                v2 = Convert.ToDouble(textBox2.Text);
                res = v1 * v2;

                textBox3.Text = res.ToString();
            }
            else
                MessageBox.Show("Preencha os dois campos com dados númericos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button6_Click(object sender, EventArgs e) //Divisão:
        {
            if (valido(textBox1.Text, textBox2.Text) && textBox2.Text!="0")
            {
                v1 = Convert.ToDouble(textBox1.Text);
                v2 = Convert.ToDouble(textBox2.Text);
                res = v1 / v2;

                textBox3.Text = res.ToString();
            }
            else if (textBox2.Text == "0")
                MessageBox.Show("Não pode haver divisão por 0 (zero)!", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("Preencha os dois campos com dados númericos!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e) //Limpa o conteúdo existente nos campo:
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox3.Clear();

            //Voltando o foco ao primeiro campo:
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e) //Sai da aplicação:
        {
            this.Close();
        }
    }
}
