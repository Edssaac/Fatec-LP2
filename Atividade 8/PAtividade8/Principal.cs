using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade8
{
    public partial class frmPrincipal : Form
    {

        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void buttonEx1_Click(object sender, EventArgs e)
        {
            Limpar();

            frmExercicio1 f = new frmExercicio1() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Base.Controls.Add(f);
            f.Show();
        }

        private void buttonEx2_Click(object sender, EventArgs e)
        {
            Limpar();

            frmExercicio2 f = new frmExercicio2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Base.Controls.Add(f);
            f.Show();
        }

        private void buttonEx3_Click(object sender, EventArgs e)
        {
            Limpar();

            frmExercicio3 f = new frmExercicio3() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Base.Controls.Add(f);
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Limpar();

            frmExercicio4 f = new frmExercicio4() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Base.Controls.Add(f);
            f.Show();
        }

        private void buttonEx5_Click(object sender, EventArgs e)
        {
            Limpar();

            frmExercicio5 f = new frmExercicio5() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Base.Controls.Add(f);
            f.Show();
        }

        private void buttonEx6_Click(object sender, EventArgs e)
        {
            Limpar();

            frmExercicio6 f = new frmExercicio6() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Base.Controls.Add(f);
            f.Show();
        }

        private void buttonEx7_Click(object sender, EventArgs e)
        {
            Limpar();

            frmExercicio7 f = new frmExercicio7() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Base.Controls.Add(f);
            f.Show();
        }


        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }


        private void Limpar()
        {
            Base.Controls.Clear();
        }



    }
}
