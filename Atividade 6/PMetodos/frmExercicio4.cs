using System.Windows.Forms;


namespace PMetodos
{
    public partial class frmExercicio4 : Form
    {
        public frmExercicio4()
        {
            InitializeComponent();
        }


        private void btnCaracteresNumericos_Click(object sender, System.EventArgs e)
        {
            int quantidade = 0;

            for (int caracter = 0; caracter < texto.Text.Length; caracter++)
            {
                if (char.IsNumber(texto.Text[caracter]))
                    quantidade++;
            }
            
            txtNumericos.Text = quantidade.ToString();
        }

        private void btnPosBranco_Click(object sender, System.EventArgs e)
        {
            int posicao = 0;
            
            if (!string.IsNullOrEmpty(texto.Text))
                while ( !char.IsWhiteSpace(texto.Text[posicao]) )
                {
                    if (posicao == texto.TextLength-1 )
                    {
                        posicao = 0;
                        break;
                    }

                    posicao++;
                }

            txtPosBranco.Text = posicao.ToString();
        }

        private void btnCaracteresAlfabeticos_Click(object sender, System.EventArgs e)
        {
            int quantidade = 0;

            foreach (char caracter in texto.Text)
            {
                if (char.IsLetter(caracter))
                    quantidade++;
            }

            txtAlfabeticos.Text = quantidade.ToString();

        }

    }
}
