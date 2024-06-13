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
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtH.Clear();

            double h = 1;

            if ( int.TryParse(txtN.Text, out int n))
            {
                if (n <= 0)
                {
                    MessageBox.Show("O número N não pode ser igual ou menor a 0.", "Atenção!", MessageBoxButtons.OK);
                    return;
                }

                for (int i=2; i<=n; i++ )
                {
                    h += 1.0 / i;
                }

                txtH.Text = h.ToString("N2");
            }
        }

    }
}
