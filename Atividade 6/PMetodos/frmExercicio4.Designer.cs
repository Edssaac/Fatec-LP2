
namespace PMetodos
{
    partial class frmExercicio4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.texto = new System.Windows.Forms.RichTextBox();
            this.btnCaracteresNumericos = new System.Windows.Forms.Button();
            this.txtNumericos = new System.Windows.Forms.TextBox();
            this.txtPosBranco = new System.Windows.Forms.TextBox();
            this.btnPosBranco = new System.Windows.Forms.Button();
            this.txtAlfabeticos = new System.Windows.Forms.TextBox();
            this.btnCaracteresAlfabeticos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.texto.Location = new System.Drawing.Point(0, 102);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(800, 348);
            this.texto.TabIndex = 0;
            this.texto.Text = "";
            // 
            // btnCaracteresNumericos
            // 
            this.btnCaracteresNumericos.Location = new System.Drawing.Point(62, 12);
            this.btnCaracteresNumericos.Name = "btnCaracteresNumericos";
            this.btnCaracteresNumericos.Size = new System.Drawing.Size(132, 52);
            this.btnCaracteresNumericos.TabIndex = 2;
            this.btnCaracteresNumericos.Text = "Quantidade de Caracteres Númericos:";
            this.btnCaracteresNumericos.UseVisualStyleBackColor = true;
            this.btnCaracteresNumericos.Click += new System.EventHandler(this.btnCaracteresNumericos_Click);
            // 
            // txtNumericos
            // 
            this.txtNumericos.Enabled = false;
            this.txtNumericos.Location = new System.Drawing.Point(200, 35);
            this.txtNumericos.Name = "txtNumericos";
            this.txtNumericos.ReadOnly = true;
            this.txtNumericos.Size = new System.Drawing.Size(59, 20);
            this.txtNumericos.TabIndex = 3;
            // 
            // txtPosBranco
            // 
            this.txtPosBranco.Enabled = false;
            this.txtPosBranco.Location = new System.Drawing.Point(440, 38);
            this.txtPosBranco.Name = "txtPosBranco";
            this.txtPosBranco.ReadOnly = true;
            this.txtPosBranco.Size = new System.Drawing.Size(59, 20);
            this.txtPosBranco.TabIndex = 5;
            // 
            // btnPosBranco
            // 
            this.btnPosBranco.Location = new System.Drawing.Point(302, 12);
            this.btnPosBranco.Name = "btnPosBranco";
            this.btnPosBranco.Size = new System.Drawing.Size(132, 52);
            this.btnPosBranco.TabIndex = 4;
            this.btnPosBranco.Text = "Posição Primeiro Caractere em Branco:";
            this.btnPosBranco.UseVisualStyleBackColor = true;
            this.btnPosBranco.Click += new System.EventHandler(this.btnPosBranco_Click);
            // 
            // txtAlfabeticos
            // 
            this.txtAlfabeticos.Enabled = false;
            this.txtAlfabeticos.Location = new System.Drawing.Point(680, 38);
            this.txtAlfabeticos.Name = "txtAlfabeticos";
            this.txtAlfabeticos.ReadOnly = true;
            this.txtAlfabeticos.Size = new System.Drawing.Size(59, 20);
            this.txtAlfabeticos.TabIndex = 7;
            // 
            // btnCaracteresAlfabeticos
            // 
            this.btnCaracteresAlfabeticos.Location = new System.Drawing.Point(542, 12);
            this.btnCaracteresAlfabeticos.Name = "btnCaracteresAlfabeticos";
            this.btnCaracteresAlfabeticos.Size = new System.Drawing.Size(132, 52);
            this.btnCaracteresAlfabeticos.TabIndex = 6;
            this.btnCaracteresAlfabeticos.Text = "Quantidade de Caracteres Alfabéticos:";
            this.btnCaracteresAlfabeticos.UseVisualStyleBackColor = true;
            this.btnCaracteresAlfabeticos.Click += new System.EventHandler(this.btnCaracteresAlfabeticos_Click);
            // 
            // frmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAlfabeticos);
            this.Controls.Add(this.btnCaracteresAlfabeticos);
            this.Controls.Add(this.txtPosBranco);
            this.Controls.Add(this.btnPosBranco);
            this.Controls.Add(this.txtNumericos);
            this.Controls.Add(this.btnCaracteresNumericos);
            this.Controls.Add(this.texto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExercicio4";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Exercício 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox texto;
        private System.Windows.Forms.Button btnCaracteresNumericos;
        private System.Windows.Forms.TextBox txtNumericos;
        private System.Windows.Forms.TextBox txtPosBranco;
        private System.Windows.Forms.Button btnPosBranco;
        private System.Windows.Forms.TextBox txtAlfabeticos;
        private System.Windows.Forms.Button btnCaracteresAlfabeticos;
    }
}