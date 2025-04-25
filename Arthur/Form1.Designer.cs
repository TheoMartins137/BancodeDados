namespace Arthur
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            btnConfirm = new Button();
            lblNome = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            ltvMostrar = new ListView();
            txtProcurar = new TextBox();
            btnPesquisar = new Button();
            ContextMenuStrip = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            btnExluir = new Button();
            ContextMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(120, 166);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(81, 23);
            btnConfirm.TabIndex = 0;
            btnConfirm.Text = "Confirmar";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(26, 30);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(26, 74);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(26, 120);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(54, 15);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(26, 48);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(175, 23);
            txtNome.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(26, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(175, 23);
            txtEmail.TabIndex = 5;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(26, 138);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(175, 23);
            txtTelefone.TabIndex = 6;
            // 
            // ltvMostrar
            // 
            ltvMostrar.Location = new Point(228, 74);
            ltvMostrar.Name = "ltvMostrar";
            ltvMostrar.Size = new Size(563, 115);
            ltvMostrar.TabIndex = 7;
            ltvMostrar.UseCompatibleStateImageBehavior = false;
            ltvMostrar.ItemSelectionChanged += ltvMostrar_ItemSelectionChanged;
            ltvMostrar.SelectedIndexChanged += ltvMostrar_SelectedIndexChanged;
            ltvMostrar.Click += toolStripMenuItem1_Click;
            // 
            // txtProcurar
            // 
            txtProcurar.Location = new Point(228, 48);
            txtProcurar.Name = "txtProcurar";
            txtProcurar.Size = new Size(444, 23);
            txtProcurar.TabIndex = 8;
            // 
            // btnPesquisar
            // 
            btnPesquisar.Location = new Point(678, 48);
            btnPesquisar.Name = "btnPesquisar";
            btnPesquisar.Size = new Size(113, 23);
            btnPesquisar.TabIndex = 9;
            btnPesquisar.Text = "Pesquisar";
            btnPesquisar.UseVisualStyleBackColor = true;
            btnPesquisar.Click += btnPesquisar_Click;
            // 
            // ContextMenuStrip
            // 
            ContextMenuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            ContextMenuStrip.Name = "ContextMenuStrip";
            ContextMenuStrip.Size = new Size(110, 26);
            ContextMenuStrip.Text = "Excluir";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(109, 22);
            toolStripMenuItem1.Text = "Excluir";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // btnExluir
            // 
            btnExluir.Location = new Point(26, 166);
            btnExluir.Name = "btnExluir";
            btnExluir.Size = new Size(81, 23);
            btnExluir.TabIndex = 11;
            btnExluir.Text = "Excluir";
            btnExluir.UseVisualStyleBackColor = true;
            btnExluir.Visible = false;
            btnExluir.Click += btnExluir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 218);
            Controls.Add(btnExluir);
            Controls.Add(btnPesquisar);
            Controls.Add(txtProcurar);
            Controls.Add(ltvMostrar);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(lblTelefone);
            Controls.Add(lblEmail);
            Controls.Add(lblNome);
            Controls.Add(btnConfirm);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ContextMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConfirm;
        private Label lblNome;
        private Label lblEmail;
        private Label lblTelefone;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private ListView ltvMostrar;
        private TextBox txtProcurar;
        private Button btnPesquisar;
        private ContextMenuStrip ContextMenuStrip;
        private ToolStripMenuItem toolStripMenuItem1;
        private Button btnExluir;
    }
}
