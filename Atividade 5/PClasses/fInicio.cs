using System;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btnMensalista_Click(object sender, EventArgs e)
        {
            frmMensalista FrmMensalista = new frmMensalista();

            FrmMensalista.Location = this.Location;

            FrmMensalista.Show();
        }

        private void btnHorista_Click(object sender, EventArgs e)
        {
            frmHorista FrmHorista = new frmHorista();

            FrmHorista.Location = this.Location;

            FrmHorista.Show();
        }
    }
}
