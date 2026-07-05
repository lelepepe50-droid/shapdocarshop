namespace Car_Shop
{
    partial class FormTelaAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaAdministrador));
            label1 = new Label();
            btnGerenciamentoCliente = new Button();
            btnGerenciamentoVendedor = new Button();
            btnGerenciamentoVeiculos = new Button();
            btnEncerreSessao = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("News706 BT", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(21, 68);
            label1.Name = "label1";
            label1.Size = new Size(363, 18);
            label1.TabIndex = 0;
            label1.Text = "Bem-Vindo a Tela de Administração do Car Shop";
            // 
            // btnGerenciamentoCliente
            // 
            btnGerenciamentoCliente.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerenciamentoCliente.Location = new Point(21, 220);
            btnGerenciamentoCliente.Name = "btnGerenciamentoCliente";
            btnGerenciamentoCliente.Size = new Size(151, 64);
            btnGerenciamentoCliente.TabIndex = 2;
            btnGerenciamentoCliente.Text = "Gerenciamento de Clientes";
            btnGerenciamentoCliente.UseVisualStyleBackColor = true;
            btnGerenciamentoCliente.Click += btnGerenciamentoCliente_Click;
            // 
            // btnGerenciamentoVendedor
            // 
            btnGerenciamentoVendedor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerenciamentoVendedor.Location = new Point(240, 220);
            btnGerenciamentoVendedor.Name = "btnGerenciamentoVendedor";
            btnGerenciamentoVendedor.Size = new Size(144, 64);
            btnGerenciamentoVendedor.TabIndex = 3;
            btnGerenciamentoVendedor.Text = "Gerenciamento de Vendedores";
            btnGerenciamentoVendedor.UseVisualStyleBackColor = true;
            btnGerenciamentoVendedor.Click += btnGerenciamentoVendedor_Click;
            // 
            // btnGerenciamentoVeiculos
            // 
            btnGerenciamentoVeiculos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGerenciamentoVeiculos.Location = new Point(21, 311);
            btnGerenciamentoVeiculos.Name = "btnGerenciamentoVeiculos";
            btnGerenciamentoVeiculos.Size = new Size(151, 62);
            btnGerenciamentoVeiculos.TabIndex = 4;
            btnGerenciamentoVeiculos.Text = "Gerenciamento de Veículos";
            btnGerenciamentoVeiculos.UseVisualStyleBackColor = true;
            btnGerenciamentoVeiculos.Click += btnGerenciamentoVeiculos_Click;
            // 
            // btnEncerreSessao
            // 
            btnEncerreSessao.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEncerreSessao.Location = new Point(240, 311);
            btnEncerreSessao.Name = "btnEncerreSessao";
            btnEncerreSessao.Size = new Size(144, 62);
            btnEncerreSessao.TabIndex = 5;
            btnEncerreSessao.Text = "Encerre a Sessão";
            btnEncerreSessao.UseVisualStyleBackColor = true;
            btnEncerreSessao.Click += btnEncerreSessao_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(34, 141);
            label2.Name = "label2";
            label2.Size = new Size(340, 16);
            label2.TabIndex = 6;
            label2.Text = "Clique nos Botões para Entrar nas Outras Páginas ";
            // 
            // FormTelaAdministrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(399, 415);
            Controls.Add(label2);
            Controls.Add(btnEncerreSessao);
            Controls.Add(btnGerenciamentoVeiculos);
            Controls.Add(btnGerenciamentoVendedor);
            Controls.Add(btnGerenciamentoCliente);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormTelaAdministrador";
            Text = "Tela de Administrador Car Shop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnGerenciamentoCliente;
        private Button btnGerenciamentoVendedor;
        private Button btnGerenciamentoVeiculos;
        private Button btnEncerreSessao;
        private Label label2;
    }
}