﻿namespace Ex_23_04
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            mnuPessoa = new ToolStripMenuItem();
            mnuCarro = new ToolStripMenuItem();
            lstJoin = new ListView();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuPessoa, mnuCarro });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(387, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuPessoa
            // 
            mnuPessoa.Name = "mnuPessoa";
            mnuPessoa.Size = new Size(108, 20);
            mnuPessoa.Text = "Cadastrar Pessoa";
            mnuPessoa.Click += mnuPessoa_Click;
            // 
            // mnuCarro
            // 
            mnuCarro.Name = "mnuCarro";
            mnuCarro.Size = new Size(101, 20);
            mnuCarro.Text = "Cadastrar Carro";
            mnuCarro.Click += mnuCarro_Click;
            // 
            // lstJoin
            // 
            lstJoin.Location = new Point(12, 27);
            lstJoin.Name = "lstJoin";
            lstJoin.Size = new Size(363, 284);
            lstJoin.TabIndex = 3;
            lstJoin.UseCompatibleStateImageBehavior = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 324);
            Controls.Add(lstJoin);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuPessoa;
        private ToolStripMenuItem mnuCarro;
        private ListView lstJoin;
    }
}
