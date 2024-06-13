using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void btnHorista_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            objHorista.Matricula = int.Parse(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.SalarioHora = double.Parse(txtSalarioHora.Text);
            objHorista.NumeroHora = double.Parse(txtNumeroHoras.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtEntradaEmpresa.Text);
            objHorista.diasFalta = int.Parse(txtDiasFalta.Text);

            
            MessageBox.Show($"Matrícula: {objHorista.Matricula}\n"+
                            $"Nome: {objHorista.NomeEmpregado}\n" +
                            $"Tempo de Trabalho: {objHorista.TempoTrabalho()}\n" +
                            $"Salário: {objHorista.SalarioBruto():N2}"  
                            );

        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
