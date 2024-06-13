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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }


        private void btnAddNumeros_Click(object sender, EventArgs e)
        {
            int i;
            int max = 20;
            int[] valores = new int[max];
            string stringona = "";

            rtfPlanilha.Clear();

            for (i = 0; i < max; i++)
            {
                var verificar = Interaction.InputBox($"Entre com o {i + 1}° número:", "Coletor de Números");

                if (verificar == "")
                    return;

                if (!int.TryParse(verificar, out int num))
                {
                    MessageBox.Show("Entre com os números adequados!");
                    i--;
                }
                else
                {
                    valores[i] = num;
                }

            }

            Array.Reverse(valores);

            for (i = max - 1; i >= 0; i--)
            {
                stringona += valores[i] + "\n";
            }

            rtfPlanilha.Text = stringona;

        }


    }
}
