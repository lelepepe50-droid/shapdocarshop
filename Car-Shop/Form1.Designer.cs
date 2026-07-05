namespace Car_Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbTelaDeConsultas = new Label();
            lbCarShop = new Label();
            lbEmail = new Label();
            txtEmail = new TextBox();
            txtSenha = new TextBox();
            lbSenha = new Label();
            btnEntrar = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lbTelaDeConsultas
            // 
            lbTelaDeConsultas.AutoSize = true;
            lbTelaDeConsultas.Font = new Font("Yu Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTelaDeConsultas.ForeColor = Color.Red;
            lbTelaDeConsultas.Location = new Point(30, 70);
            lbTelaDeConsultas.Name = "lbTelaDeConsultas";
            lbTelaDeConsultas.Size = new Size(352, 31);
            lbTelaDeConsultas.TabIndex = 1;
            lbTelaDeConsultas.Text = "Tela de Login Administrativo";
            // 
            // lbCarShop
            // 
            lbCarShop.AutoSize = true;
            lbCarShop.Location = new Point(114, 55);
            lbCarShop.Name = "lbCarShop";
            lbCarShop.Size = new Size(0, 15);
            lbCarShop.TabIndex = 6;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbEmail.Location = new Point(68, 145);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(55, 20);
            lbEmail.TabIndex = 8;
            lbEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(68, 168);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(273, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(68, 226);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(273, 23);
            txtSenha.TabIndex = 10;
            txtSenha.UseSystemPasswordChar = true; // Oculta a senha com bolinhas
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbSenha.Location = new Point(70, 203);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(58, 20);
            lbSenha.TabIndex = 11;
            lbSenha.Text = "Senha:";
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(70, 301);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(135, 61);
            btnEntrar.TabIndex = 12;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click; // Vinculado corretamente ao método de login
            // 
            // btnSair
            // 
            btnSair.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSair.Location = new Point(211, 301);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(130, 61);
            btnSair.TabIndex = 13;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 460);
            Controls.Add(btnSair);
            Controls.Add(btnEntrar);
            Controls.Add(lbSenha);
            Controls.Add(txtSenha);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(lbCarShop);
            Controls.Add(lbTelaDeConsultas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Tela de Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbTelaDeConsultas;
        private Label lbCarShop;
        private Label lbEmail;
        private TextBox txtEmail;
        private TextBox txtSenha;
        private Label lbSenha;
        private Button btnEntrar;
        private Button btnSair;
    }
}