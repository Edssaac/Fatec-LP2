using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PAtividade8
{
    public partial class frmExercicio6 : Form
    {
        public frmExercicio6()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            rtfPlanilha.Clear();

            double[] medias = new double[20];
            double[,] notas = new double[20, 3];
            string stringona = string.Empty;
            int i, j;

            for (i=0; i<20; i++)
            {
                for (j = 0; j<3; j++)
                {
                    var leitura = Interaction.InputBox($"Nota #{j + 1}:", $"Notas Aluno #{i + 1}");

                    if (leitura == "")
                        return;

                    if (!double.TryParse(leitura, out notas[i,j]))
                    {
                        MessageBox.Show("Nota Inválida - Tente Novamente.", "Atenção");
                        j--;
                        continue;
                    }

                    medias[i] += notas[i, j];
                }
                medias[i] = (medias[i] / 3.0);
            }

            for (i=0; i<20; i++)
            {
                stringona += $"Aluno {i+1}: média: {medias[i]:N1}\n";
            }

            rtfPlanilha.Text = stringona;

        }


    }
}
