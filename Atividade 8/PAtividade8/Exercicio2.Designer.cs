
namespace PAtividade8
{
    partial class frmExercicio2
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
            this.rtfPlanilha = new System.Windows.Forms.RichTextBox();
            this.btnAddNumeros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtfPlanilha
            // 
            this.rtfPlanilha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfPlanilha.Enabled = false;
            this.rtfPlanilha.Location = new System.Drawing.Point(384, 12);
            this.rtfPlanilha.Name = "rtfPlanilha";
            this.rtfPlanilha.Size = new System.Drawing.Size(191, 426);
            this.rtfPlanilha.TabIndex = 3;
            this.rtfPlanilha.Text = "";
            // 
            // btnAddNumeros
            // 
            this.btnAddNumeros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddNumeros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNumeros.Location = new System.Drawing.Point(38, 267);
            this.btnAddNumeros.Name = "btnAddNumeros";
            this.btnAddNumeros.Size = new System.Drawing.Size(201, 58);
            this.btnAddNumeros.TabIndex = 2;
            this.btnAddNumeros.Text = "Adicionar Números";
            this.btnAddNumeros.UseVisualStyleBackColor = true;
            this.btnAddNumeros.Click += new System.EventHandler(this.btnAddNumeros_Click);
            // 
            // frmExercicio2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.ControlBox = false;
            this.Controls.Add(this.rtfPlanilha);
            this.Controls.Add(this.btnAddNumeros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExercicio2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exercicio2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtfPlanilha;
        private System.Windows.Forms.Button btnAddNumeros;
    }
}