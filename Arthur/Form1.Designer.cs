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
            SuspendLayout();
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(26, 167);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(175, 23);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 218);
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
    }
}
