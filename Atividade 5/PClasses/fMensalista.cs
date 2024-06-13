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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }


        private void btnMensalista_Click(object sender, EventArgs e)
        {
            Mensalista objMensalista = new Mensalista( int.Parse(txtMatricula.Text),
                                                       txtNome.Text,
                                                       double.Parse(txtSalarioMensal.Text),
                                                       Convert.ToDateTime(txtEntradaEmpresa.Text)
                                                     );

            //get
            MessageBox.Show($"Matrícula : {objMensalista.Matricula}\n" +
                            $"Nome : {objMensalista.NomeEmpregado}\n" +
                            $"Data de Entrada : {objMensalista.DataEntradaEmpresa.ToShortDateString()}\n" +
                            $"Salário Bruto : {objMensalista.SalarioBruto():N2}\n" +
                            $"Tempo na Empresa : {objMensalista.TempoTrabalho()}\n"
                            );

        }

        private void btnMensalistaParametros_Click(object sender, EventArgs e)
        {
            //Criar ou instanciar um objeto da classe Mensalista:
            Mensalista objMensalista = new Mensalista();

            //set
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtEntradaEmpresa.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalarioMensal.Text);

            //get
            MessageBox.Show($"Matrícula : {objMensalista.Matricula}\n" +
                            $"Nome : {objMensalista.NomeEmpregado}\n" +
                            $"Data de Entrada : {objMensalista.DataEntradaEmpresa.ToShortDateString()}\n" +
                            $"Salário Bruto : {objMensalista.SalarioBruto():N2}\n" +
                            $"Tempo na Empresa : {objMensalista.TempoTrabalho()}\n"
                );

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            //frmInicio FrmInicio = new frmInicio();

            this.Close();
        }


    }
}
