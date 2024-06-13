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
    public partial class frmPai : Form
    {
        public frmPai()
        {
            InitializeComponent();
        }

        Form aberto = new Form();

        private void exercício1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Dispose();

            frmExercicio1 f = new frmExercicio1();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;

            f.Show();
            aberto = f;
        }

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Dispose();

            frmExercicio2 f = new frmExercicio2();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;

            f.Show();
            aberto = f;
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Dispose();

            frmExercicio3 f = new frmExercicio3();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;

            f.Show();
            aberto = f;
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aberto.Dispose();

            frmExercicio4 f = new frmExercicio4();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;

            f.Show();
            aberto = f;
        }



        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
