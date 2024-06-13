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
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int produtos = 10;
            int[] quantidade = new int[produtos];
            double[] valor = new double[produtos];
            double faturado = 0;
            string stringona = string.Empty;

            for ( int i=0; i<produtos; i++ )
            {
                var leitura = Interaction.InputBox( "Quantidade Vendida:", $"Produto #{i+1}" );

                if (leitura == "")
                    return;

                if (!int.TryParse(leitura, out quantidade[i]))
                {
                    MessageBox.Show("Quantidade Informada Inválida, Tente Novamente.", "Atenção!");
                    i--;
                    continue;
                }

                leitura = Interaction.InputBox( "Valor Unitário:", $"Produto #{i + 1}" );

                if (!double.TryParse(leitura, out valor[i]))
                {
                    MessageBox.Show("Valor Informado Inválido, Tente Novamente.", "Atenção!");
                    i--;
                    continue;
                }

                faturado += quantidade[i] * valor[i];
                stringona += $"Produto #{i + 1} - Vendidos: {quantidade[i]} -- Preço Unitário: {valor[i]:N2}\n";

            }

            txtPlanilha.Text = stringona;
            txtFaturamento.Text = faturado.ToString("N2");

        }


    }
}
