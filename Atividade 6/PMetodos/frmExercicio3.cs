using System.Windows.Forms;
using System.Linq;

namespace PMetodos
{
    public partial class frmExercicio3 : Form
    {
        public frmExercicio3()
        {
            InitializeComponent();
        }



        private void btnRemover1_Click(object sender, System.EventArgs e)
        {
            int tam = txtPalavra1.Text.Length;
            int index = txtPalavra2.Text.IndexOf(txtPalavra1.Text);

            while (index > -1)
            {
                txtPalavra2.Text = txtPalavra2.Text.Substring(0, index) + txtPalavra2.Text.Substring(index+tam);
                index = txtPalavra2.Text.IndexOf(txtPalavra1.Text);
            }
                
        }

        private void btnRemover2_Click(object sender, System.EventArgs e)
        {
            txtPalavra2.Text = txtPalavra2.Text.Replace(txtPalavra1.Text, "");
        }

        private void btnInverter_Click(object sender, System.EventArgs e)
        {
            string stringona = new string(txtPalavra1.Text.Reverse().ToArray());
            MessageBox.Show(stringona);
        }

        
    }
}
