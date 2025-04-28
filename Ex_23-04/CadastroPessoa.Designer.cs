namespace Ex_23_04
{
    partial class CadastroPessoa
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
            button1 = new Button();
            txtNome = new TextBox();
            txtCPF = new TextBox();
            txtTelefone = new TextBox();
            lstLista = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 202);
            button1.Name = "button1";
            button1.Size = new Size(125, 23);
            button1.TabIndex = 0;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 28);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "Nome:";
            txtNome.Size = new Size(125, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCPF
            // 
            txtCPF.Location = new Point(12, 86);
            txtCPF.Name = "txtCPF";
            txtCPF.PlaceholderText = "CPF:";
            txtCPF.Size = new Size(125, 23);
            txtCPF.TabIndex = 2;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(12, 144);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone:";
            txtTelefone.Size = new Size(125, 23);
            txtTelefone.TabIndex = 5;
            // 
            // lstLista
            // 
            lstLista.Location = new Point(175, 28);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(366, 197);
            lstLista.TabIndex = 6;
            lstLista.UseCompatibleStateImageBehavior = false;
            lstLista.ItemSelectionChanged += lstLista_ItemSelectionChanged;
            // 
            // CadastroPessoa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 253);
            Controls.Add(lstLista);
            Controls.Add(txtTelefone);
            Controls.Add(txtCPF);
            Controls.Add(txtNome);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadastroPessoa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroPessoa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtNome;
        private TextBox txtCPF;
        private TextBox txtTelefone;
        private ListView lstLista;
    }
}