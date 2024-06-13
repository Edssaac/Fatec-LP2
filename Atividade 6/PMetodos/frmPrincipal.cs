using System;
using System.Windows.Forms;

namespace PMetodos
{
    public partial class frmPrincipal : Form
    {
        string nomeBase;

        public frmPrincipal()
        {
            InitializeComponent();
            nomeBase = this.Text; //Pegando o nome que esatamos usando em nosso form principal;
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        Form frmAberto = new Form(); //Criando um formulario base;
        

        private void exercício2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAberto.Dispose(); //Fechando o formulario que já esta aberto - se houver;

            frmExercicio2 fe2 = new frmExercicio2(); //Criando um novo Objeto;
            fe2.MdiParent = this; //Fixando o novo Objeto (Formulario) no formulario principal;
            //fe2.WindowState = FormWindowState.Maximized;
            fe2.Dock = DockStyle.Fill;

            this.Text = nomeBase + " - " + fe2.Text; //Atualizando o nome de nosso form principal;
            fe2.Show(); //Exibindo;
            frmAberto = fe2; //Passando o atual formulario;
        }

        private void exercício3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAberto.Dispose();

            frmExercicio3 fe3 = new frmExercicio3(); //Criando um novo Objeto;
            fe3.MdiParent = this; //Fixando o novo Objeto (Formulario) no formulario principal;
            //fe3.WindowState = FormWindowState.Maximized;
            fe3.Dock = DockStyle.Fill;

            this.Text = nomeBase + " - " + fe3.Text; //Atualizando o nome de nosso form principal;
            fe3.Show(); //Exibindo;
            frmAberto = fe3; //Alterando a informação sobre o formulário aberto.
        }

        private void exercício4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAberto.Dispose();

            frmExercicio4 fe4 = new frmExercicio4(); //Criando um novo Objeto;
            fe4.MdiParent = this; //Fixando o novo Objeto (Formulario) no formulario principal;
            //fe4.WindowState = FormWindowState.Maximized;
            fe4.ContextMenuStrip = this.contextMenuMetodos; //Adicioando o menu de contexto ao RichTextBox
            fe4.Dock = DockStyle.Fill;

            this.Text = nomeBase + " - " + fe4.Text; //Atualizando o nome de nosso form principal;
            fe4.Show(); //Exibindo;
            frmAberto = fe4; //Alterando a informação sobre o formulário aberto.
        }

        private void exercício5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAberto.Dispose();

            frmExercicio5 fe5 = new frmExercicio5(); //Criando um novo Objeto;
            fe5.MdiParent = this; //Fixando o novo Objeto (Formulario) no formulario principal;
            //fe5.WindowState = FormWindowState.Maximized;
            fe5.Dock = DockStyle.Fill;

            this.Text = nomeBase + " - " + fe5.Text; //Atualizando o nome de nosso form principal;
            fe5.Show(); //Exibindo;
            frmAberto = fe5; //Alterando a informação sobre o formulário aberto.
        }

        //Como foi removido o botão de fechar, temos um menu de contexto para podermos substituir essa função:
        private void fecharFormulárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAberto.Dispose();
            this.Text = nomeBase; //Limpando o nome do form principal;
        }

    }
}
