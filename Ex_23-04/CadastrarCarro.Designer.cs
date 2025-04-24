namespace Ex_23_04
{
    partial class CadastrarCarro
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
            lstLista = new ListView();
            txtID = new TextBox();
            txtModelo = new TextBox();
            txtMarca = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lstLista
            // 
            lstLista.Location = new Point(182, 34);
            lstLista.Name = "lstLista";
            lstLista.Size = new Size(360, 197);
            lstLista.TabIndex = 11;
            lstLista.UseCompatibleStateImageBehavior = false;
            // 
            // txtID
            // 
            txtID.Location = new Point(19, 150);
            txtID.Name = "txtID";
            txtID.PlaceholderText = "Id do proprietario:";
            txtID.Size = new Size(125, 23);
            txtID.TabIndex = 10;
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(19, 92);
            txtModelo.Name = "txtModelo";
            txtModelo.PlaceholderText = "Modelo:";
            txtModelo.Size = new Size(125, 23);
            txtModelo.TabIndex = 9;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(19, 34);
            txtMarca.Name = "txtMarca";
            txtMarca.PlaceholderText = "Marca:";
            txtMarca.Size = new Size(125, 23);
            txtMarca.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(19, 208);
            button1.Name = "button1";
            button1.Size = new Size(125, 23);
            button1.TabIndex = 7;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CadastrarCarro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 264);
            Controls.Add(lstLista);
            Controls.Add(txtID);
            Controls.Add(txtModelo);
            Controls.Add(txtMarca);
            Controls.Add(button1);
            Name = "CadastrarCarro";
            Text = "CadastrarCarro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lstLista;
        private TextBox txtID;
        private TextBox txtModelo;
        private TextBox txtMarca;
        private Button button1;
    }
}