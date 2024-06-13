using System;
using System.Windows.Forms;

namespace Triângulos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.ladoA.Clear();
            this.ladoB.Clear();
            this.ladoC.Clear();

            this.tipo.Clear();

            this.ladoA.Focus();
        }

        private void btnDescobrir_Click(object sender, EventArgs e)
        {
            int tamA, tamB, tamC;

            this.label4.Focus();

            if (int.TryParse(ladoA.Text, out tamA) && int.TryParse(ladoB.Text, out tamB) && int.TryParse(ladoC.Text, out tamC))
            {
                if ((Math.Abs(tamB - tamC) < tamA && tamA < (tamB + tamC)) && (Math.Abs(tamA - tamC) < tamB && tamA < (tamA + tamC)) && (Math.Abs(tamA - tamB) < tamC && tamA < (tamA + tamB)))
                {
                    //Fazer os testes:
                    if ( tamA==tamB && tamA==tamC )
                    {
                        this.tipo.Text = "Equilátero";
                    }
                    else if ( (tamA==tamB&&tamA!=tamC) || (tamA==tamC&&tamA!=tamB) || (tamB==tamC&&tamB!=tamA) )
                    {
                        this.tipo.Text = "Isósceles";
                    }
                    else
                    {
                        this.tipo.Text = "Escaleno";
                    }

                }
                else
                {
                    this.tipo.Text = "Triângulo não formado.";
                }

            }
            else
            {
                MessageBox.Show("Certifique-se se todos os campos\nestão preenchidos com dados númericos.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
