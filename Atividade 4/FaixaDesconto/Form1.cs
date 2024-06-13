using System;
using System.Drawing;
using System.Windows.Forms;

namespace FaixaDesconto
{
    public partial class Form1 : Form
    {
        bool arrastar = false;
        Point posicaoInicial = new Point(0, 0);

        double descontoINSS, descontoIRPF, salarioFamilia, salarioBruto, salarioLiquido;
        byte numeroFilhos;


        public Form1()
        {
            InitializeComponent();
        }

        #region Borda Top
        private void BordaTop_MouseDown(object sender, MouseEventArgs e)
        {
            arrastar = true;
            posicaoInicial = new Point(e.X, e.Y);
        }

        private void BordaTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastar)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - posicaoInicial.X, p.Y - posicaoInicial.Y);
            }

        }

        private void BordaTop_MouseUp(object sender, MouseEventArgs e)
        {
            arrastar = false;
        }


        private void imgFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void btnLimpar_Click(object sender, EventArgs e) //Limpando todos os campos existentes:
        {
            this.mskNome.Clear();
            this.mskBruto.Clear();
            this.mskFilhos.Clear();
            this.estadoCivil.SelectedIndex = -1;

            this.mskAliquota_INSS.Clear();
            this.mskAliquota_IRFF.Clear();
            this.mskSalario_Familia.Clear();
            this.mskSalario_Liquido.Clear();
            this.mskDesconto_INSS.Clear();
            this.mskDesconto_IRFF.Clear();

            this.labelFrase.Text = string.Empty;

            this.imgPerfil.Image = Properties.Resources.user;

            this.labelNome.Visible = false;
            this.labelNome.Text = string.Empty;

            this.mskNome.Focus();
        }

        private void btnDesconto_Click(object sender, EventArgs e)
        {
            //Limpar espaços em branco, se existentes:
            this.mskNome.Text = this.mskNome.Text.Trim(); //Limpando os cantos.
            this.mskNome.Text = this.mskNome.Text.Replace("  ", " "); //Limpando os meios.

            if (this.mskNome.Text == string.Empty || this.mskNome.Text.Length < 4) //Verificando nome:
            {
                this.mskNome.Focus();
                MessageBox.Show("Nome curto demais ou não presente.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                descontoINSS = 0;
                descontoIRPF = 0;
                salarioFamilia = 0;

                if (double.TryParse(this.mskBruto.Text, out salarioBruto)
                     && this.estadoCivil.SelectedIndex != -1
                     && byte.TryParse(this.mskFilhos.Text, out numeroFilhos)
                   )
                {
                    //INSS:
                    if (salarioBruto <= 800.47)
                    {
                        this.mskAliquota_INSS.Text = "7.65%";
                        descontoINSS = 7.65 / 100 * salarioBruto;
                    }
                    else if (salarioBruto <= 1050.00)
                    {
                        this.mskAliquota_INSS.Text = "8.65%";
                        descontoINSS = 8.65 / 100 * salarioBruto;
                    }
                    else if (salarioBruto <= 1400.77)
                    {
                        this.mskAliquota_INSS.Text = "9.00%";
                        descontoINSS = 9.00 / 100 * salarioBruto;
                    }
                    else if (salarioBruto <= 2801.56)
                    {
                        this.mskAliquota_INSS.Text = "11.00%";
                        descontoINSS = 11.00 / 100 * salarioBruto;
                    }
                    else
                    {
                        this.mskAliquota_INSS.Text = "308.17";
                        descontoINSS = 308.17;
                    }

                    //IRPF:
                    if (salarioBruto <= 1257.12)
                    {
                        this.mskAliquota_IRFF.Text = "Isento";
                    }
                    else if (salarioBruto <= 2512.08)
                    {
                        this.mskAliquota_IRFF.Text = "15.00%";
                        descontoIRPF = 15.00 / 100 * salarioBruto;
                    }
                    else
                    {
                        this.mskAliquota_IRFF.Text = "27.50%";
                        descontoIRPF = 27.50 / 100 * salarioBruto;
                    }

                    //Salário Família:
                    if (salarioBruto <= 435.52)
                        salarioFamilia = 22.33 * numeroFilhos;
                    else if (salarioBruto <= 654.61)
                        salarioFamilia = 15.74 * numeroFilhos;
                    else
                        salarioFamilia = 0;

                    //Salário Líquido:
                    salarioLiquido = salarioBruto - descontoINSS - descontoIRPF + salarioFamilia;


                    //Passando as informações para os componentes:
                    this.mskDesconto_INSS.Text = descontoINSS.ToString("N2");
                    this.mskDesconto_IRFF.Text = descontoIRPF.ToString("N2");
                    this.mskSalario_Familia.Text = salarioFamilia.ToString("N2");
                    this.mskSalario_Liquido.Text = salarioLiquido.ToString("N2");


                    //Trocando o icone de usuário:
                    if (Masculino.Checked)
                    {
                        this.imgPerfil.Image = Properties.Resources.man;
                    }
                    else if (Feminino.Checked)
                    {
                        this.imgPerfil.Image = Properties.Resources.woman;
                    }

                    //Adionando o nome na barra inferior:
                    this.labelNome.Text = this.mskNome.Text;
                    this.labelNome.Visible = true;

                    //Texto de apresentação:
                    this.labelFrase.Text = string.Format("Os descontos do salário {0} {1}, que é {2} e possui {3} filho(s) são:",
                    (Masculino.Checked) ? "do Sr." : "da Sra.",
                    this.mskNome.Text,
                    this.estadoCivil.SelectedItem.ToString().ToLower(), 
                    this.mskFilhos.Text);

                    this.labelFrase.Focus();

                }
                else
                {
                    MessageBox.Show("Preencha todos os dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.labelHora.Text = DateTime.Now.ToString("HH:mm");
            this.labelDia.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void mskNome_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.mskNome.Text.Length == 0) //Mandando o mouse para o inicio do maskedtextbox se o texto estiver vazio:
                SendKeys.Send("{Home}");
            else if (this.mskNome.SelectionStart > this.mskNome.Text.Length) //Se não estiver, impede de clicar em posição não alcançada ainda:
                this.mskNome.SelectionStart = this.mskNome.Text.Length;

        }


    }
}
