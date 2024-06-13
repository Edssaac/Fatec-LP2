using System;
using System.Windows.Forms;
using Microsoft.VisualBasic; //Para usar InputBox();

namespace ProvaLP2
{
    public partial class fmrPlanilha : Form
    {
        public fmrPlanilha()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            //Criando a Matriz:      //meses,semanas
            double[,] vendas = new double[10, 4];
            double totalSemanas = 0, totalMeses = 0;
            int mes, semana;
            string r;

            //Fazendo a entrada dos dados de vendas:

            //Para Cada Mês:
            for ( mes=0; mes<vendas.GetLength(0); mes++ )
            {
                //Para Cada Semana:
                for ( semana=0; semana<vendas.GetLength(1); semana++ )
                {
                    //Recebendo um valor:
                    r = Interaction.InputBox($"Semana #{semana+1}", $"Mês #{mes+1}");

                    //Se não houver uma entrada de dados, ou se cancelar for selecionado:
                    if (r == string.Empty)
                        return;

                    //Certificando-se que os valores inseridos são válidos:
                    if (!double.TryParse(r, out vendas[mes,semana]))
                    {
                        MessageBox.Show("Valor informado inválido!\nPor favor, apenas dados númericos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        semana--;
                    }
                }
            }

            //Calculando e Gerando a Saída:
            if (listFaturamento.Items.Count > 0) //Verificando se já existem itens,
            {
                //Se existir, colocamos uma separação maior para não ficar muito junto/confuso:
                listFaturamento.Items.Add("----------------------------------------------------");
            }

            for (mes = 0; mes < vendas.GetLength(0); mes++)
            {
                totalSemanas = 0;

                for (semana = 0; semana < vendas.GetLength(1); semana++)
                {
                    listFaturamento.Items.Add($"Total do mês: {mes+1} Semana: {semana+1}: {vendas[mes,semana]:C2}");
                    totalSemanas += vendas[mes, semana];
                }

                listFaturamento.Items.Add($">> Total Mês: {totalSemanas:C2}");
                totalMeses += totalSemanas;
                listFaturamento.Items.Add("-------------");
            }

            listFaturamento.Items.Add($">> Total Geral: {totalMeses:C2}");
        }

        //Para limparmos a lista se for desejado:
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            listFaturamento.Items.Clear();
        }
    }
}
