using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAtividade8
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }


        private void btnNomes_Click(object sender, EventArgs e)
        {
            rtfPlanilha.Clear();

            ArrayList Nomes = new ArrayList() { "Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais" };

            /*List<string> Nomes = new List<string>()
            {"Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais"};*/

            Nomes.Remove("Otávio");

            for (int i=0; i<Nomes.Count; i++)
            {
                rtfPlanilha.Text += Nomes[i] + "\n";
            }

        }


    }
}
