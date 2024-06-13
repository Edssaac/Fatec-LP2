using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMetodos2
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int B, C, D;

            if (
                double.TryParse(txtSalario.Text, out double salario) &&
                double.TryParse(txtProducao.Text, out double producao) &&
                double.TryParse(txtGratificacao.Text, out double gratificacao)
               )
            {
                B = (producao >= 100) ? 1 : 0;
                C = (producao >= 120) ? 1 : 0;
                D = (producao >= 150) ? 1 : 0;

                double salarioBruto = salario + salario * (0.05*B + 0.1*C + 0.1*D) + gratificacao;

                if (salarioBruto > 7000 && (producao < 150 || gratificacao == 0))
                    salarioBruto = 7000;

                txtSalarioBruto.Text = salarioBruto.ToString("N2");
            }
            else
            {
                MessageBox.Show("Preencha todos os dados!");
            }
        }


    }
}
