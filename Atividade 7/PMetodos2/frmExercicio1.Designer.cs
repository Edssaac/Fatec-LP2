
namespace PMetodos2
{
    partial class frmExercicio1
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
            this.labelQuantidades = new System.Windows.Forms.Label();
            this.btnBrancos = new System.Windows.Forms.Button();
            this.btnLetrasR = new System.Windows.Forms.Button();
            this.btnPares = new System.Windows.Forms.Button();
            this.txtBrancos = new System.Windows.Forms.TextBox();
            this.txtLetrasR = new System.Windows.Forms.TextBox();
            this.txtPares = new System.Windows.Forms.TextBox();
            this.rtfFrase = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelQuantidades
            // 
            this.labelQuantidades.AutoSize = true;
            this.labelQuantidades.Location = new System.Drawing.Point(13, 118);
            this.labelQuantidades.Name = "labelQuantidades";
            this.labelQuantidades.Size = new System.Drawing.Size(70, 13);
            this.labelQuantidades.TabIndex = 1;
            this.labelQuantidades.Text = "Quantidades:";
            // 
            // btnBrancos
            // 
            this.btnBrancos.Location = new System.Drawing.Point(15, 153);
            this.btnBrancos.Name = "btnBrancos";
            this.btnBrancos.Size = new System.Drawing.Size(122, 48);
            this.btnBrancos.TabIndex = 1;
            this.btnBrancos.Text = "Espaços em Branco";
            this.btnBrancos.UseVisualStyleBackColor = true;
            this.btnBrancos.Click += new System.EventHandler(this.btnBrancos_Click);
            // 
            // btnLetrasR
            // 
            this.btnLetrasR.Location = new System.Drawing.Point(16, 209);
            this.btnLetrasR.Name = "btnLetrasR";
            this.btnLetrasR.Size = new System.Drawing.Size(122, 48);
            this.btnLetrasR.TabIndex = 2;
            this.btnLetrasR.Text = "Letras R";
            this.btnLetrasR.UseVisualStyleBackColor = true;
            this.btnLetrasR.Click += new System.EventHandler(this.btnLetrasR_Click);
            // 
            // btnPares
            // 
            this.btnPares.Location = new System.Drawing.Point(16, 265);
            this.btnPares.Name = "btnPares";
            this.btnPares.Size = new System.Drawing.Size(122, 48);
            this.btnPares.TabIndex = 3;
            this.btnPares.Text = "Pares de Letras";
            this.btnPares.UseVisualStyleBackColor = true;
            this.btnPares.Click += new System.EventHandler(this.btnPares_Click);
            // 
            // txtBrancos
            // 
            this.txtBrancos.Enabled = false;
            this.txtBrancos.Location = new System.Drawing.Point(156, 168);
            this.txtBrancos.Name = "txtBrancos";
            this.txtBrancos.Size = new System.Drawing.Size(63, 20);
            this.txtBrancos.TabIndex = 5;
            // 
            // txtLetrasR
            // 
            this.txtLetrasR.Enabled = false;
            this.txtLetrasR.Location = new System.Drawing.Point(156, 224);
            this.txtLetrasR.Name = "txtLetrasR";
            this.txtLetrasR.Size = new System.Drawing.Size(63, 20);
            this.txtLetrasR.TabIndex = 6;
            // 
            // txtPares
            // 
            this.txtPares.Enabled = false;
            this.txtPares.Location = new System.Drawing.Point(156, 280);
            this.txtPares.Name = "txtPares";
            this.txtPares.Size = new System.Drawing.Size(63, 20);
            this.txtPares.TabIndex = 7;
            // 
            // rtfFrase
            // 
            this.rtfFrase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtfFrase.Location = new System.Drawing.Point(375, 29);
            this.rtfFrase.MaxLength = 100;
            this.rtfFrase.Name = "rtfFrase";
            this.rtfFrase.Size = new System.Drawing.Size(425, 389);
            this.rtfFrase.TabIndex = 0;
            this.rtfFrase.Text = "";
            // 
            // frmExercicio1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.ControlBox = false;
            this.Controls.Add(this.rtfFrase);
            this.Controls.Add(this.txtPares);
            this.Controls.Add(this.txtLetrasR);
            this.Controls.Add(this.txtBrancos);
            this.Controls.Add(this.btnPares);
            this.Controls.Add(this.btnLetrasR);
            this.Controls.Add(this.btnBrancos);
            this.Controls.Add(this.labelQuantidades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 447);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 447);
            this.Name = "frmExercicio1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Exercício 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelQuantidades;
        private System.Windows.Forms.Button btnBrancos;
        private System.Windows.Forms.Button btnLetrasR;
        private System.Windows.Forms.Button btnPares;
        private System.Windows.Forms.TextBox txtBrancos;
        private System.Windows.Forms.TextBox txtLetrasR;
        private System.Windows.Forms.TextBox txtPares;
        private System.Windows.Forms.RichTextBox rtfFrase;
    }
}