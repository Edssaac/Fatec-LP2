using System.Windows.Forms;

namespace PMetodos
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show( (string.Compare(txtPalavra1.Text, txtPalavra2.Text) == 0) ? "São Iguais!" : "Não São Iguais!" );

            /*if ( string.Compare(txtPalavra1.Text, txtPalavra2.Text) == 0 )
            {
                MessageBox.Show("São Iguais!");
            }
            else
            {
                MessageBox.Show("Não São Iguais!");
            }*/

        }

        private void btnInserirTexto_Click(object sender, System.EventArgs e)
        {
            int meio = txtPalavra2.Text.Length / 2;
            int fim = txtPalavra2.Text.Length - meio;
            txtPalavra2.Text = txtPalavra2.Text.Substring(0, meio) + txtPalavra1.Text + txtPalavra2.Text.Substring(meio, fim);

            //MessageBox.Show(txtPalavra1.Text.Substring(0, meio));
            //MessageBox.Show(txtPalavra1.Text.Substring(meio, fim-meio));
        }

        private void btnInserirAsteriscos_Click(object sender, System.EventArgs e)
        {
            int meio = txtPalavra1.Text.Length/2;
            txtPalavra1.Text = txtPalavra1.Text.Insert(meio, "**");
        }
        
    }
}
