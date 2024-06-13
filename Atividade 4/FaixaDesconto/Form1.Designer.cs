
namespace FaixaDesconto
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BordaTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imgFechar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupoSexo = new System.Windows.Forms.GroupBox();
            this.Feminino = new System.Windows.Forms.RadioButton();
            this.Masculino = new System.Windows.Forms.RadioButton();
            this.estadoCivil = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDesconto = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.BordaBot = new System.Windows.Forms.Panel();
            this.labelDia = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgPerfil = new System.Windows.Forms.PictureBox();
            this.mskNome = new System.Windows.Forms.MaskedTextBox();
            this.mskFilhos = new System.Windows.Forms.MaskedTextBox();
            this.mskBruto = new System.Windows.Forms.MaskedTextBox();
            this.mskAliquota_INSS = new System.Windows.Forms.MaskedTextBox();
            this.mskAliquota_IRFF = new System.Windows.Forms.MaskedTextBox();
            this.mskSalario_Familia = new System.Windows.Forms.MaskedTextBox();
            this.mskSalario_Liquido = new System.Windows.Forms.MaskedTextBox();
            this.mskDesconto_IRFF = new System.Windows.Forms.MaskedTextBox();
            this.mskDesconto_INSS = new System.Windows.Forms.MaskedTextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.labelFrase = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.BordaTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupoSexo.SuspendLayout();
            this.BordaBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BordaTop
            // 
            this.BordaTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.BordaTop.Controls.Add(this.panel2);
            this.BordaTop.Controls.Add(this.imgFechar);
            this.BordaTop.Controls.Add(this.pictureBox1);
            this.BordaTop.Controls.Add(this.label11);
            this.BordaTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BordaTop.Location = new System.Drawing.Point(0, 0);
            this.BordaTop.Name = "BordaTop";
            this.BordaTop.Size = new System.Drawing.Size(890, 37);
            this.BordaTop.TabIndex = 0;
            this.BordaTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BordaTop_MouseDown);
            this.BordaTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BordaTop_MouseMove);
            this.BordaTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BordaTop_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(890, 1);
            this.panel2.TabIndex = 26;
            // 
            // imgFechar
            // 
            this.imgFechar.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgFechar.Image = global::FaixaDesconto.Properties.Resources.fechar;
            this.imgFechar.Location = new System.Drawing.Point(853, 7);
            this.imgFechar.Name = "imgFechar";
            this.imgFechar.Size = new System.Drawing.Size(23, 23);
            this.imgFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFechar.TabIndex = 25;
            this.imgFechar.TabStop = false;
            this.imgFechar.Click += new System.EventHandler(this.imgFechar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "Faixa de Desconto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Funcionário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salário Bruto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "Número de Filhos:";
            // 
            // groupoSexo
            // 
            this.groupoSexo.Controls.Add(this.Feminino);
            this.groupoSexo.Controls.Add(this.Masculino);
            this.groupoSexo.Location = new System.Drawing.Point(672, 62);
            this.groupoSexo.Name = "groupoSexo";
            this.groupoSexo.Size = new System.Drawing.Size(188, 125);
            this.groupoSexo.TabIndex = 5;
            this.groupoSexo.TabStop = false;
            this.groupoSexo.Text = "Sexo";
            // 
            // Feminino
            // 
            this.Feminino.AutoSize = true;
            this.Feminino.Location = new System.Drawing.Point(57, 74);
            this.Feminino.Name = "Feminino";
            this.Feminino.Size = new System.Drawing.Size(81, 19);
            this.Feminino.TabIndex = 1;
            this.Feminino.Text = "Feminino";
            this.Feminino.UseVisualStyleBackColor = true;
            // 
            // Masculino
            // 
            this.Masculino.AutoSize = true;
            this.Masculino.Checked = true;
            this.Masculino.Location = new System.Drawing.Point(57, 31);
            this.Masculino.Name = "Masculino";
            this.Masculino.Size = new System.Drawing.Size(88, 19);
            this.Masculino.TabIndex = 0;
            this.Masculino.TabStop = true;
            this.Masculino.Text = "Masculino";
            this.Masculino.UseVisualStyleBackColor = true;
            // 
            // estadoCivil
            // 
            this.estadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoCivil.FormattingEnabled = true;
            this.estadoCivil.Items.AddRange(new object[] {
            "Casado(a)",
            "Solteiro(a)"});
            this.estadoCivil.Location = new System.Drawing.Point(437, 105);
            this.estadoCivil.Name = "estadoCivil";
            this.estadoCivil.Size = new System.Drawing.Size(182, 23);
            this.estadoCivil.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(333, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "Estado Cívil:";
            // 
            // btnDesconto
            // 
            this.btnDesconto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDesconto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDesconto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDesconto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesconto.Location = new System.Drawing.Point(757, 395);
            this.btnDesconto.Name = "btnDesconto";
            this.btnDesconto.Size = new System.Drawing.Size(119, 53);
            this.btnDesconto.TabIndex = 6;
            this.btnDesconto.Text = "Verificar Desconto";
            this.btnDesconto.UseVisualStyleBackColor = false;
            this.btnDesconto.Click += new System.EventHandler(this.btnDesconto_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alíquota INSS:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Alíquota IRPF:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 14);
            this.label7.TabIndex = 10;
            this.label7.Text = "Salário Família:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Salário Líquido:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(313, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 14);
            this.label9.TabIndex = 12;
            this.label9.Text = "Desconto INSS:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(313, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 14);
            this.label10.TabIndex = 13;
            this.label10.Text = "Desconto IRPF:";
            // 
            // BordaBot
            // 
            this.BordaBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(193)))), ((int)(((byte)(218)))));
            this.BordaBot.Controls.Add(this.labelDia);
            this.BordaBot.Controls.Add(this.labelNome);
            this.BordaBot.Controls.Add(this.labelHora);
            this.BordaBot.Controls.Add(this.panel1);
            this.BordaBot.Controls.Add(this.imgPerfil);
            this.BordaBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BordaBot.Location = new System.Drawing.Point(0, 469);
            this.BordaBot.Name = "BordaBot";
            this.BordaBot.Size = new System.Drawing.Size(890, 50);
            this.BordaBot.TabIndex = 14;
            // 
            // labelDia
            // 
            this.labelDia.AutoSize = true;
            this.labelDia.Location = new System.Drawing.Point(799, 26);
            this.labelDia.Name = "labelDia";
            this.labelDia.Size = new System.Drawing.Size(77, 15);
            this.labelDia.TabIndex = 32;
            this.labelDia.Text = "00/00/0000";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(65, 16);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(198, 19);
            this.labelNome.TabIndex = 27;
            this.labelNome.Text = "Nome de Teste Usuário";
            this.labelNome.Visible = false;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(799, 11);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(42, 15);
            this.labelHora.TabIndex = 31;
            this.labelHora.Text = "00:00";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(223)))), ((int)(((byte)(237)))));
            this.panel1.Location = new System.Drawing.Point(55, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 51);
            this.panel1.TabIndex = 26;
            // 
            // imgPerfil
            // 
            this.imgPerfil.Image = global::FaixaDesconto.Properties.Resources.user;
            this.imgPerfil.Location = new System.Drawing.Point(14, 11);
            this.imgPerfil.Name = "imgPerfil";
            this.imgPerfil.Size = new System.Drawing.Size(29, 29);
            this.imgPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgPerfil.TabIndex = 25;
            this.imgPerfil.TabStop = false;
            // 
            // mskNome
            // 
            this.mskNome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mskNome.Location = new System.Drawing.Point(168, 62);
            this.mskNome.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mskNome.Name = "mskNome";
            this.mskNome.PromptChar = ' ';
            this.mskNome.Size = new System.Drawing.Size(451, 23);
            this.mskNome.TabIndex = 1;
            this.mskNome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mskNome_MouseUp);
            // 
            // mskFilhos
            // 
            this.mskFilhos.HidePromptOnLeave = true;
            this.mskFilhos.Location = new System.Drawing.Point(168, 147);
            this.mskFilhos.Mask = "00";
            this.mskFilhos.Name = "mskFilhos";
            this.mskFilhos.Size = new System.Drawing.Size(37, 23);
            this.mskFilhos.TabIndex = 3;
            this.mskFilhos.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mskBruto
            // 
            this.mskBruto.Location = new System.Drawing.Point(168, 104);
            this.mskBruto.Mask = "000000.00";
            this.mskBruto.Name = "mskBruto";
            this.mskBruto.Size = new System.Drawing.Size(109, 23);
            this.mskBruto.TabIndex = 2;
            // 
            // mskAliquota_INSS
            // 
            this.mskAliquota_INSS.Enabled = false;
            this.mskAliquota_INSS.Location = new System.Drawing.Point(168, 304);
            this.mskAliquota_INSS.Name = "mskAliquota_INSS";
            this.mskAliquota_INSS.Size = new System.Drawing.Size(126, 23);
            this.mskAliquota_INSS.TabIndex = 18;
            // 
            // mskAliquota_IRFF
            // 
            this.mskAliquota_IRFF.Enabled = false;
            this.mskAliquota_IRFF.Location = new System.Drawing.Point(168, 338);
            this.mskAliquota_IRFF.Name = "mskAliquota_IRFF";
            this.mskAliquota_IRFF.Size = new System.Drawing.Size(126, 23);
            this.mskAliquota_IRFF.TabIndex = 19;
            // 
            // mskSalario_Familia
            // 
            this.mskSalario_Familia.Enabled = false;
            this.mskSalario_Familia.Location = new System.Drawing.Point(168, 374);
            this.mskSalario_Familia.Name = "mskSalario_Familia";
            this.mskSalario_Familia.Size = new System.Drawing.Size(126, 23);
            this.mskSalario_Familia.TabIndex = 20;
            // 
            // mskSalario_Liquido
            // 
            this.mskSalario_Liquido.Enabled = false;
            this.mskSalario_Liquido.Location = new System.Drawing.Point(168, 409);
            this.mskSalario_Liquido.Name = "mskSalario_Liquido";
            this.mskSalario_Liquido.Size = new System.Drawing.Size(126, 23);
            this.mskSalario_Liquido.TabIndex = 21;
            // 
            // mskDesconto_IRFF
            // 
            this.mskDesconto_IRFF.Enabled = false;
            this.mskDesconto_IRFF.Location = new System.Drawing.Point(416, 409);
            this.mskDesconto_IRFF.Name = "mskDesconto_IRFF";
            this.mskDesconto_IRFF.Size = new System.Drawing.Size(126, 23);
            this.mskDesconto_IRFF.TabIndex = 23;
            // 
            // mskDesconto_INSS
            // 
            this.mskDesconto_INSS.Enabled = false;
            this.mskDesconto_INSS.Location = new System.Drawing.Point(416, 374);
            this.mskDesconto_INSS.Name = "mskDesconto_INSS";
            this.mskDesconto_INSS.Size = new System.Drawing.Size(126, 23);
            this.mskDesconto_INSS.TabIndex = 22;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(623, 395);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(119, 53);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar Dados";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // labelFrase
            // 
            this.labelFrase.AutoSize = true;
            this.labelFrase.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrase.Location = new System.Drawing.Point(36, 244);
            this.labelFrase.MaximumSize = new System.Drawing.Size(500, 0);
            this.labelFrase.Name = "labelFrase";
            this.labelFrase.Size = new System.Drawing.Size(0, 15);
            this.labelFrase.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 518);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(890, 1);
            this.panel3.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1, 519);
            this.panel4.TabIndex = 28;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(889, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 519);
            this.panel5.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(731, 307);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 72);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(223)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(890, 519);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelFrase);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.mskDesconto_IRFF);
            this.Controls.Add(this.mskDesconto_INSS);
            this.Controls.Add(this.mskSalario_Liquido);
            this.Controls.Add(this.mskSalario_Familia);
            this.Controls.Add(this.mskAliquota_IRFF);
            this.Controls.Add(this.mskAliquota_INSS);
            this.Controls.Add(this.mskBruto);
            this.Controls.Add(this.mskFilhos);
            this.Controls.Add(this.mskNome);
            this.Controls.Add(this.BordaBot);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDesconto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.estadoCivil);
            this.Controls.Add(this.groupoSexo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BordaTop);
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.BordaTop.ResumeLayout(false);
            this.BordaTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupoSexo.ResumeLayout(false);
            this.groupoSexo.PerformLayout();
            this.BordaBot.ResumeLayout(false);
            this.BordaBot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BordaTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupoSexo;
        private System.Windows.Forms.RadioButton Feminino;
        private System.Windows.Forms.RadioButton Masculino;
        private System.Windows.Forms.ComboBox estadoCivil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDesconto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel BordaBot;
        private System.Windows.Forms.MaskedTextBox mskNome;
        private System.Windows.Forms.MaskedTextBox mskFilhos;
        private System.Windows.Forms.MaskedTextBox mskBruto;
        private System.Windows.Forms.MaskedTextBox mskAliquota_INSS;
        private System.Windows.Forms.MaskedTextBox mskAliquota_IRFF;
        private System.Windows.Forms.MaskedTextBox mskSalario_Familia;
        private System.Windows.Forms.MaskedTextBox mskSalario_Liquido;
        private System.Windows.Forms.MaskedTextBox mskDesconto_IRFF;
        private System.Windows.Forms.MaskedTextBox mskDesconto_INSS;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.PictureBox imgFechar;
        private System.Windows.Forms.PictureBox imgPerfil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelFrase;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelDia;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Timer Timer;
    }
}

