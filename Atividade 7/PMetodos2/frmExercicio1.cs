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
    public partial class frmExercicio1 : Form
    {
        public frmExercicio1()
        {
            InitializeComponent();
        }


        private void btnBrancos_Click(object sender, EventArgs e)
        {
            string texto = rtfFrase.Text;
            int Brancos = 0;
            int pos = texto.Length-1;

            if ( texto != string.Empty )
                while ( pos >= 0 )
                {
                    if (texto[pos] == ' ')
                        Brancos++;

                    pos--;
                }

            txtBrancos.Text = Brancos.ToString();
        }

        private void btnLetrasR_Click(object sender, EventArgs e)
        {
            int R = 0;

            foreach (char letra in rtfFrase.Text)
            {
                if ( char.ToUpper(letra) == 'R' )
                {
                    R++;
                }
            }

            txtLetrasR.Text = R.ToString();
        }

        private void btnPares_Click(object sender, EventArgs e)
        {
            int Pares = 0;
            string texto = rtfFrase.Text;

            for ( int letra=0; letra<texto.Length-1; letra++ )
            {
                if (texto[letra] == texto[letra+1])
                    Pares++;
            }

            txtPares.Text = Pares.ToString();
        }


    }
}
