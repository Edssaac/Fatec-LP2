using System.Windows.Forms;
using System;

namespace PMetodos
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, System.EventArgs e)
        {
            Random sortido = new Random();
            int num1, num2;

            if (int.Parse(txtNum1.Text) <= int.Parse(txtNum2.Text))
            {
                num1 = int.Parse(txtNum1.Text);
                num2 = int.Parse(txtNum2.Text);
            }
            else
            {
                num1 = int.Parse(txtNum2.Text);
                num2 = int.Parse(txtNum1.Text);
            }

            txtSorteio.Text = sortido.Next(num1, num2).ToString();
        }
    }
}
