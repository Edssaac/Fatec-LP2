﻿
namespace PMetodos2
{
    partial class frmPai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPai));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exercício1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercício4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercício1ToolStripMenuItem,
            this.exercício2ToolStripMenuItem,
            this.exercício3ToolStripMenuItem,
            this.exercício4ToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exercício1ToolStripMenuItem
            // 
            this.exercício1ToolStripMenuItem.Name = "exercício1ToolStripMenuItem";
            this.exercício1ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.exercício1ToolStripMenuItem.Text = "Exercício &1";
            this.exercício1ToolStripMenuItem.Click += new System.EventHandler(this.exercício1ToolStripMenuItem_Click);
            // 
            // exercício2ToolStripMenuItem
            // 
            this.exercício2ToolStripMenuItem.Name = "exercício2ToolStripMenuItem";
            this.exercício2ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.exercício2ToolStripMenuItem.Text = "Exercício &2";
            this.exercício2ToolStripMenuItem.Click += new System.EventHandler(this.exercício2ToolStripMenuItem_Click);
            // 
            // exercício3ToolStripMenuItem
            // 
            this.exercício3ToolStripMenuItem.Name = "exercício3ToolStripMenuItem";
            this.exercício3ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.exercício3ToolStripMenuItem.Text = "Exercício &3";
            this.exercício3ToolStripMenuItem.Click += new System.EventHandler(this.exercício3ToolStripMenuItem_Click);
            // 
            // exercício4ToolStripMenuItem
            // 
            this.exercício4ToolStripMenuItem.Name = "exercício4ToolStripMenuItem";
            this.exercício4ToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.exercício4ToolStripMenuItem.Text = "Exercício &4";
            this.exercício4ToolStripMenuItem.Click += new System.EventHandler(this.exercício4ToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "&Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // frmPai
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(790, 404);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 447);
            this.MinimumSize = new System.Drawing.Size(810, 447);
            this.Name = "frmPai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Métodos 2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exercício1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercício4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

