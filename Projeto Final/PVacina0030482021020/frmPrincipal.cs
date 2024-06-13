using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System;
using System.Drawing;

namespace PVacina0030482021020
{
    public partial class frmPrincipal : Form
    {

        public static SqlConnection conexao;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            foreach (Control mdi in Controls)
            {
                if ( mdi is MdiClient)
                mdi.BackColor = Color.FromArgb(255, 154, 237, 255);

            }

            try
            {   ///Tentando conectar ao banco de dados:
                conexao = new SqlConnection(@"Data Source=LAPTOP-KVMNA2JF\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }
            catch (SqlException ex)
            {   ///Se não der certo:
                MessageBox.Show(ex.Message, "Erro no Bando de Dados", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao tentar acessar o Banco de Dados", MessageBoxButtons.OK);
            }

        }


        Form fOpened = new Form();
        private void cadastroDeVacinaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            fOpened.Dispose();
            frmVacina f = new frmVacina();
            f.MdiParent = this;
            f.Dock = DockStyle.Fill;
            pbxLogo.Visible = false;
            f.Show();

            fOpened = f;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre f = new frmSobre();
            f.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_ControlRemoved(object sender, ControlEventArgs e)
        {
            MessageBox.Show("Test");
        }
    }
}
