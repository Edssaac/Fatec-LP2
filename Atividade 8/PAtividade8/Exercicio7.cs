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
    public partial class frmExercicio7 : Form
    {
        public frmExercicio7()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int tam = 10;
            string[] Nomes = new string[tam];
            int[] caracteres = new int[tam];
            int i, j;

            for ( i=0; i<tam; i++ )
            {
                var leitura = Interaction.InputBox($"Entre com o #{i+1} nome", "Cadastro de Nomes");

                if (leitura == "")
                    return;

                if (string.IsNullOrWhiteSpace(leitura))
                {
                    i--;
                    MessageBox.Show("Nome Inválido!", "Atenção");
                    continue;
                }

                Nomes[i] = leitura;
                int count = 0;

                for ( j=0; j<leitura.Length; j++ )
                {
                    if (!char.IsWhiteSpace(leitura[j]))
                        count++;
                }

                caracteres[i] = count;
            }
            
            for ( i=0; i<tam; i++ )
            {
                listNomes.Items.Add($"O nome: {Nomes[i]} tem {caracteres[i]} caracteres");
            }
            
        }


    }
}
