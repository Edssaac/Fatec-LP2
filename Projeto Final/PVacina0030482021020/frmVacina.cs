using System;
using System.Data;
using System.Windows.Forms;

namespace PVacina0030482021020
{
    public partial class frmVacina : Form
    {
        private bool bInclusao = false;

        private BindingSource bnVacina = new BindingSource();
        private DataSet dsVacina = new DataSet();

        private BindingSource bnCidade = new BindingSource();
        private DataSet dsCidade = new DataSet();

        private BindingSource bnEnfermeiro = new BindingSource();
        private DataSet dsEnfermeiro = new DataSet();

        public frmVacina()
        {
            InitializeComponent();
        }

        private void frmVacina_Load(object sender, EventArgs e)
        {
            try
            {
                Vacina RegVac = new Vacina();
                dsVacina.Tables.Add(RegVac.Listar());
                bnVacina.DataSource = dsVacina.Tables["VACINA"];
                dgvVacina.DataSource = bnVacina;
                bnvVacina.BindingSource = bnVacina;

                txtID.DataBindings.Add("Text", bnVacina, "id_vacina");
                txtNome.DataBindings.Add("Text", bnVacina, "nome_vacina");
                txtEndereco.DataBindings.Add("Text", bnVacina, "end_vacina");
                dtDataNascimento.DataBindings.Add("Text", bnVacina, "datanasc_vacina");
                dtVacina.DataBindings.Add("Text", bnVacina, "data_vacina");
                mskCPF.DataBindings.Add("Text", bnVacina, "cpf_vacina");
                mskRG.DataBindings.Add("Text", bnVacina, "rg_vacina");
                cbxComorbidade.DataBindings.Add("SelectedItem", bnVacina, "comorbidade_vacina");
                cbxPrioritario.DataBindings.Add("SelectedItem", bnVacina, "grupopriori_vacina");
                cbxVacina.DataBindings.Add("SelectedItem", bnVacina, "tipo_vacina");

                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                cbxCidade.DataSource = dsCidade.Tables["CIDADE"];

                Enfermeiro Enf = new Enfermeiro();
                dsCidade.Tables.Add(Enf.Listar());
                cbxEnfermeiro.DataSource = dsCidade.Tables["ENFERMEIRO"];

                cbxCidade.DataBindings.Add("SelectedValue", bnVacina, "cidade_id_cidade");
                cbxEnfermeiro.DataBindings.Add("SelectedValue", bnVacina, "enfermeiro_id_enfermeiro");

                cbxCidade.DisplayMember = "nome_cidade";
                cbxCidade.ValueMember = "id_cidade";

                cbxEnfermeiro.DisplayMember = "nome_enfermeiro";
                cbxEnfermeiro.ValueMember = "id_enfermeiro";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Segue o erro:\n" + ex, "Houve algum problema ao iniciar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void bntNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tbVacina.SelectedIndex == 0)
            {
                tbVacina.SelectTab(1);
            }

            bnVacina.AddNew();

            AtivarCampos(true);

            cbxComorbidade.SelectedIndex = 0;
            cbxPrioritario.SelectedIndex = 0;
            cbxVacina.SelectedIndex = 0;

            cbxCidade.SelectedIndex = 0;
            cbxEnfermeiro.SelectedIndex = 0;

            bInclusao = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ///Validando os dados:
            if (string.IsNullOrWhiteSpace(txtNome.Text))
                MessageBox.Show("Nome vazio");
            else if (string.IsNullOrWhiteSpace(txtEndereco.Text))
                MessageBox.Show("Endereço vazio");
            else if (string.IsNullOrWhiteSpace(mskCPF.Text))
                MessageBox.Show("CPF vazio");
            else if (string.IsNullOrWhiteSpace(mskRG.Text))
                MessageBox.Show("RG vazio");
            else
            {
                Vacina RegVac = new Vacina();

                RegVac.nomeVacina = txtNome.Text;
                RegVac.endVacina = txtEndereco.Text;
                RegVac.dataNascVacina = Convert.ToDateTime(dtDataNascimento.Text);
                RegVac.dataVacina = Convert.ToDateTime(dtVacina.Text);
                RegVac.cpfVacina = mskCPF.Text;
                RegVac.rgVacina = mskRG.Text;
                RegVac.grupoPrioriVacina = Convert.ToChar(cbxPrioritario.SelectedItem.ToString());
                RegVac.tipoVacina = Convert.ToChar(cbxVacina.SelectedItem.ToString());
                RegVac.comorbidadeVacina = Convert.ToChar(cbxComorbidade.SelectedItem.ToString());
                RegVac.cidadeIdVacina = Convert.ToInt32(cbxCidade.SelectedValue.ToString());
                RegVac.enfermeiroIdEnfermeiro = Convert.ToInt32(cbxEnfermeiro.SelectedValue.ToString());

                if (bInclusao)
                {
                    if (RegVac.Salvar() > 0)
                    {
                        MessageBox.Show("Vacina adicionada com sucesso!", "Parabéns");

                        AtivarCampos(false);

                        bInclusao = false;

                        //Recarregar o grid
                        RecarregarGrid(RegVac);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar vacina!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    RegVac.idVacina = Convert.ToInt32(txtID.Text);

                    if (RegVac.Alterar() > 0)
                    {
                        MessageBox.Show("Vacina alterada com sucesso!", "Parabéns");

                        AtivarCampos(false);

                        //Recarregar o grid
                        RecarregarGrid(RegVac);
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar vacina!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pbxLogoSalvar_Click(object sender, EventArgs e)
        {
            btnSalvar_Click(sender, e);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (tbVacina.SelectedIndex == 0)
            {
                tbVacina.SelectTab(1);
            }

            AtivarCampos(true);

            bInclusao = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbVacina.SelectedIndex == 0)
            {
                tbVacina.SelectTab(1);
            }
            Vacina RegVac = new Vacina();

            RegVac.idVacina = Convert.ToInt32(txtID.Text);

            if (MessageBox.Show("Confirma exclusão?", "Cuidado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (RegVac.Excluir() == 0)
                    MessageBox.Show("Erro ao excluir vacina!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    MessageBox.Show("Vacina excluida com sucesso!", "Parabéns");

                    //Recarregar o grid
                    RecarregarGrid(RegVac);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnVacina.CancelEdit();

            AtivarCampos(false);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            try
            {
                //acessar a instancia do form1 pelo form2 
                frmPrincipal form1 = Application.OpenForms["frmPrincipal"] as frmPrincipal;

                //significa se nao for nulo q ja existe o form1 aberto
                if (form1 != null)
                {
                    //aqui altera a imagem
                    form1.pbxLogo.Visible = true;
                }
            }
            catch 
            {

            }


            Close();
        }


        private void RecarregarGrid(Vacina reg)
        {
            dsVacina.Tables.Clear();
            dsVacina.Tables.Add(reg.Listar());
            bnVacina.DataSource = dsVacina.Tables["vacina"];
        }

        private void AtivarCampos(bool bln)
        {
            txtNome.Enabled = bln;
            txtEndereco.Enabled = bln;
            dtDataNascimento.Enabled = bln;
            dtVacina.Enabled = bln;
            mskCPF.Enabled = bln;
            mskRG.Enabled = bln;
            cbxCidade.Enabled = bln;
            cbxEnfermeiro.Enabled = bln;
            cbxComorbidade.Enabled = bln;
            cbxPrioritario.Enabled = bln;
            cbxVacina.Enabled = bln;

            btnSalvar.Enabled = bln;
            pbxLogoSalvar.Enabled = bln;
            btnAlterar.Enabled = (bln != true) ? true : false;
            btnNovoRegistro.Enabled = (bln != true) ? true : false;
            btnExcluir.Enabled = (bln != true) ? true : false;
            btnCancelar.Enabled = bln;
        }

        private void FocusOn0( MaskedTextBox msk )
        {
            if (string.IsNullOrWhiteSpace(msk.Text))
            {
                SendKeys.Send("{Home}");
            }
        }

        private void mskCPF_Click(object sender, EventArgs e)
        {
            FocusOn0(mskCPF);
        }

        private void mskRG_Click(object sender, EventArgs e)
        {
            FocusOn0(mskRG);
        }


    }
}
